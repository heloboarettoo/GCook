using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("Receitas")]
public class Receita
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "A categoria é obrigatória")]
    public int CategoriaId { get; set; }
    [Display(Name = "Categoria")]
    public Categoria Categoria { get; set; }

    [StringLength(100)]
    [Required(ErrorMessage = " O nome é obrigatório")]






}
