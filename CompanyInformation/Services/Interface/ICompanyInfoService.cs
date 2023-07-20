using CompanyInformation.Dto;
using CompanyInformation.Services.Objects;
using System;

namespace CompanyInformation.Services.Interface
{
    public interface ICompanyInfoService
    {
        public Response GetCompanyInfo(GetCompanyInfoDto getCompanyInfoDto);
    }
}
