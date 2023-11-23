using System.ComponentModel.DataAnnotations;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    public class RegisterVM
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        public string? PasswordConfirm { get; set; }
    }
}
