using System.Threading.Tasks;
using TwojePrzedszkole.API.Models;

namespace TwojePrzedszkole.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExist(string usename);
    }
}