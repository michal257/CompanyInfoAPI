using CompanyInformation.Entities;
using System;
using System.Net.Http;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.CompilerServices;
using CompanyInformation.Dto;
using CompanyInformation.Services.Interface;
using CompanyInformation.Services.Objects;

namespace CompanyInformation.Services
{
    public class CompanyInfoService : ICompanyInfoService
    {
        private CompanyInformationContext _dbContext;

        public CompanyInfoService(CompanyInformationContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public Response GetCompanyInfo(GetCompanyInfoDto getCompanyInfoDto)
        {
            Response response = new Response();

            try
            {
                string sDate = getCompanyInfoDto.Date.ToString("yyyy-MM-dd");
                
                var builder = new UriBuilder();
                builder.Scheme = "https";
                builder.Host = "wl-api.mf.gov.pl";
                builder.Path = "api/search/nip/" + getCompanyInfoDto.NipNumber;
                builder.Query = "date=" + sDate;

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    HttpResponseMessage responseMessage = client.GetAsync(builder.Uri).Result;

                    string responsbody = responseMessage.Content.ReadAsStringAsync().Result;

                    if (responseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        response = JsonConvert.DeserializeObject<Response>(responsbody);
                        response.result.companyInfo.requestDateTime = DateTime.Parse(response.result.requestDateTime);
                        response.result.companyInfo.requestId = response.result.requestId;
                        _dbContext.CompanyInfos.Add(response.result.companyInfo);
                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        response.errorObject = JsonConvert.DeserializeObject<ErrorObject>(responsbody);
                    }

                    return response;
                }

            }
            catch(Exception ex)
            {
                response.errorObject.message = ex.Message;
                return response;
            }
        }
    }
}
