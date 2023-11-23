using System.ComponentModel.DataAnnotations;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    // класс модели-представления (view-model)
    public class LoginVM
    {
        [Required]
        public string? Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
