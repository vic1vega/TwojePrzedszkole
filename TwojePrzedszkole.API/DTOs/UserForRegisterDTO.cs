using System.ComponentModel.DataAnnotations;

namespace TwojePrzedszkole.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required(ErrorMessage="Nazwa użytkownika jest wymagana.")]
        public string Username { get; set; }
        [Required(ErrorMessage="Hasło jest wymagane.")]
        [StringLength(10, MinimumLength=6, ErrorMessage="Hasło powinno mieć od 6 do 10 znaków")]
        public string Password { get; set; }
    }
}