using DotNetCore.Extensions;
using DotNetCore.Objects;
using DotNetCore.Security;
using HRMS.CrossCutting.Resources;
using HRMS.Model;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace HRMS.Infra
{
    public class SignInService : ISignInService
    {
        public SignInService
        (
            IHashService hash,
            JsonWebToken jsonWebToken
        )
        {
            Hash = hash;
            JsonWebToken = jsonWebToken;
        }

        private IHashService Hash { get; }

        private JsonWebToken JsonWebToken { get; }

        public SignInModel CreateSignIn(SignInModel signInModel)
        {
            var salt = Guid.NewGuid().ToString();

            var password = Hash.Create(signInModel.Password, salt);

            return new SignInModel
            {
                Login = signInModel.Login,
                Password = password,
                Salt = salt
            };
        }

        public TokenModel CreateToken(SignedInModel signedInModel)
        {
            var claims = new List<Claim>();

            claims.AddSub(signedInModel.UserId.ToString());

            claims.AddRoles(signedInModel.Roles.ToString().Split(", "));

            return new TokenModel(JsonWebToken.EncodedToken);
        }

        public IResult Validate(SignedInModel signedInModel, SignInModel signInModel)
        {
            var errorResult = Result.Fail(Texts.LoginPasswordInvalid);

            if (signedInModel == default || signInModel == default) { return errorResult; }

            var password = Hash.Create(signInModel.Password, signedInModel.SignIn.Salt);

            if (signedInModel.SignIn.Password != password) { return errorResult; }

            return Result.Success();
        }
    }
}
