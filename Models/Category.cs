using System.ComponentModel.DataAnnotations;

namespace BlazorShopping.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o titulo")]
        [MinLength(2, ErrorMessage = "O titulo deve ter pelo menos 2 caracteres")]
        public string Title { get; set; } = string.Empty;
    }
}
