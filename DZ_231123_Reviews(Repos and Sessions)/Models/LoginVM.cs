using System.ComponentModel.DataAnnotations;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    // класс модели-представления (view-model)
    public class LoginVM
    {
        [Required]
        [Display(Name = "Логін")]
        public string? Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string? Password { get; set; }
    }
}
