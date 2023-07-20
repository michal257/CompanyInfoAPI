using CompanyInformation.Entities;
using Newtonsoft.Json;

namespace CompanyInformation.Services.Objects
{
    public class Result
    {
        [JsonProperty(PropertyName = "Subject")]
        public CompanyInfo companyInfo { get; set; }
        public string requestId { get; set; }
        public string requestDateTime { get; set; }
    }

    public class Response
    {
        public Result result { get; set; }
        public ErrorObject errorObject { get; set; }
    }
}
