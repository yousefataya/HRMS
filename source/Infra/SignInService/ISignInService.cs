using DotNetCore.Objects;
using HRMS.Model;

namespace HRMS.Infra
{
    public interface ISignInService
    {
        SignInModel CreateSignIn(SignInModel signInModel);

        TokenModel CreateToken(SignedInModel signedInModel);

        IResult Validate(SignedInModel signedInModel, SignInModel signInModel);
    }
}
