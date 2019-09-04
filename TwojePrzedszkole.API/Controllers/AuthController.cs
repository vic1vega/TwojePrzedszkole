using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwojePrzedszkole.API.Data;
using TwojePrzedszkole.API.DTOs;
using TwojePrzedszkole.API.Models;

namespace TwojePrzedszkole.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;

        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDTO userForRegisterDTO)
        {
            userForRegisterDTO.Username = userForRegisterDTO.Username.ToLower();
            if (await _repository.UserExist(userForRegisterDTO.Username))
            {
                return BadRequest("Użytkownik o takiej nazwie już istnieje.");
            }

            var userToCreate = new User{
                Username = userForRegisterDTO.Username
            };

            var createdUser = await _repository.Register(userToCreate, userForRegisterDTO.Password);

            return StatusCode(201);
        }
    }
}