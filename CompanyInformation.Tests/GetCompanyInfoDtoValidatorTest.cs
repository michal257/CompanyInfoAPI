using CompanyInformation.Dto;
using CompanyInformation.Validators;
using FluentValidation.TestHelper;
using System;
using Xunit;

namespace CompanyInformation.Tests
{
    public class GetCompanyInfoDtoValidatorTest
    {
        [Fact]
        public void Validate_ForCorrectModel_ReturnsSuccess()
        {
            //arrange
            var validator = new GetCompanyInfoDtoValidator();
            var model = new GetCompanyInfoDto()
            {
                NipNumber = "5252691064",
                Date = new DateTime(2023, 07, 14)
            };

            //act
            var result = validator.TestValidate(model);

            //assert
            result.ShouldNotHaveAnyValidationErrors();
        }

        [Fact]
        public void Validate_ForNotCorrectModel_ReturnsFail()
        {
            //arrange
            var validator = new GetCompanyInfoDtoValidator();
            var model = new GetCompanyInfoDto()
            {
                NipNumber = "5252691",
                Date = new DateTime()
            };

            //act
            var result = validator.TestValidate(model);

            //assert
            result.ShouldHaveAnyValidationError();
        }
    }
}
