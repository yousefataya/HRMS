using HRMS.Model;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application
{
    public interface IUserLogApplicationService
    {
        Task AddAsync(UserLogModel userLogModel);
    }
}
