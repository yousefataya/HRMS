using DotNetCore.Validation;
using HRMS.CrossCutting.Resources;
using FluentValidation;

namespace HRMS.Model
{
    public sealed class SignInModelValidator : Validator<SignInModel>
    {
        public SignInModelValidator()
        {
            WithMessage(Texts.LoginPasswordInvalid);
            RuleFor(x => x.Login).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
