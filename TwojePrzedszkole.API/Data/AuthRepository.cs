using System;
using System.Text;
using System.Threading.Tasks;
using TwojePrzedszkole.API.Models;

namespace TwojePrzedszkole.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        #region public method
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public Task<User> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;

            CreatePasswordHashSalt(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public Task<bool> UserExist(string usename)
        {
            throw new System.NotImplementedException();
        }
        #endregion
        #region private method
        private void CreatePasswordHashSalt(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));     
            }
        }
        #endregion
    }
}