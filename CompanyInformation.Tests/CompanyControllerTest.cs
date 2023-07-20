using CompanyInformation.Dto;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CompanyInformation.Tests
{
    public class CompanyControllerTest
    {
        [Fact]
        public async Task Post_ReturnsOkResult()
        {
            //arrange
            var factory = new WebApplicationFactory<Startup>();
            var client = factory.CreateClient();

            var companyInfoDto = new GetCompanyInfoDto()
            {
                NipNumber = "5252691064",
                Date = new DateTime(2023, 07, 14)
            };

            string json = JsonConvert.SerializeObject(companyInfoDto);
            
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");


            //act
            var response = await client.PostAsync("/api/company", httpContent);

            //assert
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}
