using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace GCook.Models;

[Table("Comentario")]
public class Comentario
{
     [Key]
     public int Id { get; set; }  

     [Display(Name = "Receita")] 
     [Required(ErrorMessage = "A Receita é obrigatória")]
     public int ReceitaId { get; set; }
     [ForeignKey("ReceitaId")]
     [Display(Name = "Receita")]
     public Receita Receita { get; set; }

     [Display(Name = "Usuario")] 
     [Required(ErrorMessage = "O Usuario é obrigatória")]
     public string UsuarioId { get; set; }
     [ForeignKey("UsuarioId")]
     [Display(Name = "USuario")]
     public Usuario Usuario { get; set; }

     [Display(Name = "Data do comentário")] 
     [Required(ErrorMessage = "A Data é obrigatória")]
     public DateTime? DataComentario { get; set; }

     [StringLength(300)]
     [Required(ErrorMessage = "O Texto é obrigatório")]
     public string TextoComentario { get; set; }
}
