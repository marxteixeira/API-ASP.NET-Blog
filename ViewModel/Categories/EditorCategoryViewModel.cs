using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Esse campo deve conter no mínimo 3 e no máximo 40")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O slug é obrigatório.")]
        public string Slug { get; set; }
    }
}
