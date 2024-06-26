using System.ComponentModel.DataAnnotations;

namespace scopewebsite.Models
{
    public class Class1
    {
        [Required(ErrorMessage ="*enter your name*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email Required*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Subject Required*")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message Required*")]
        public string Message { get; set; }
    }                                         
}
