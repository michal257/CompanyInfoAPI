using CompanyInformation.Dto;
using FluentValidation;

namespace CompanyInformation.Validators
{
    public class GetCompanyInfoDtoValidator : AbstractValidator<GetCompanyInfoDto>
    {
        public GetCompanyInfoDtoValidator()
        {
            RuleFor(x => x.NipNumber).NotEmpty().Length(10);
            RuleFor(x => x.Date).NotEmpty().NotNull();
        }
    }
}
