using DotNetCore.AspNetCore;
using DotNetCore.Extensions;
using DotNetCore.Objects;
using HRMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreArchitecture.Web
{
    public abstract class BaseController : ControllerBase
    {
        protected UserModel UserModel => new UserModel
        {
            UserId = User.Id(),
            Roles = User.RolesFlag<Roles>()
        };

        protected static OkObjectResult Result(IResult result)
        {
            return new OkObjectResult(result);
        }
    }
}
