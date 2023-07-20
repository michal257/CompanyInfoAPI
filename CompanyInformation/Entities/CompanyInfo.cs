using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace CompanyInformation.Entities
{
    [JsonObject("Subject")]
    public class CompanyInfo
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string nip { get; set; }
        public string statusVat { get; set; }
        public string regon { get; set; }
        public string krs { get; set; }
        public string workingAddress { get; set; }
        public DateTime registrationLegalDate { get; set; }
        public DateTime requestDateTime { get; set; }
        public string requestId { get; set; }
    }
}
