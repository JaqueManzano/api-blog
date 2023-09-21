using System.ComponentModel.DataAnnotations;

namespace Blogv2.ViewModels.Accounts;

public class UploadImageViewModel
{
    [Required(ErrorMessage = "Imagem Inválida")]
    public string Base64Image { get; set; }
}
