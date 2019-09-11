using System.Collections.Generic;
using System.Threading.Tasks;
using TwojePrzedszkole.API.Models;

namespace TwojePrzedszkole.API.Data
{
    public interface IUserRepository : IGenericRepository
    {
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}