using System.ComponentModel.DataAnnotations;

namespace Blogv2.ViewModels.Categories;

public class EditorCategoryViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(maximumLength: 40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O slug é obrigatório.")]
    public string Slug { get; set; }
}
