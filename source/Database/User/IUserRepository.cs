using DotNetCore.Repositories;
using DotNetCoreArchitecture.Domain;
using HRMS.Model;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Database
{
    public interface IUserRepository : IRelationalRepository<UserEntity>
    {
        Task<SignedInModel> SignInAsync(SignInModel signInModel);

        Task UpdateStatusAsync(UserEntity userEntity);
    }
}
