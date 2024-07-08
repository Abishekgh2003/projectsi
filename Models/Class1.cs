using System.ComponentModel.DataAnnotations;

namespace scopewebsite.Models
{
    public class Class1
    {
        [Required(ErrorMessage ="*enter your name*")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email Required*")]
        [Display(Name ="enter email")]
        [EmailAddress]
        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }                                         
}
