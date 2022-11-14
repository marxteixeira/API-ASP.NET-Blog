using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o E-mail.")]
        [EmailAddress(ErrorMessage ="E-mail Inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a senha.")]
        public string Password { get; set; }
    }
}
