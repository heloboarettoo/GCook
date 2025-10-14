using System.ComponentModel.DataAnnotations;
namespace GCook.ViewModels;

public class LoginVM
{
    [Display(Name = "Emails ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "O Email ou Nome de Usário é obrigatório")]
    public string Email { get; set; }

   [Display(Name = "Senha de Acesso", Prompt = "****")]
   [Required(ErrorMessage = "A Senha é obrigatório")]
   [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter conectado?")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
    
}
