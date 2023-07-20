using CompanyInformation.Dto;
using CompanyInformation.Entities;
using CompanyInformation.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CompanyInformation.Controllers
{
    [ApiController]
    [Route("api/company")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyInfoService _companyInfoService;

        public CompanyController(ICompanyInfoService companyInfoService)
        {
            _companyInfoService = companyInfoService;
        }
        
        [HttpPost]
        public ActionResult<CompanyInfo> Post([FromBody] GetCompanyInfoDto getCompanyInfoDto)
        {
            var products = _companyInfoService.GetCompanyInfo(getCompanyInfoDto);
            return Ok(products);
        }
    }
}
