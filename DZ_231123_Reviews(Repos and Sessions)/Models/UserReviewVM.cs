using System.ComponentModel.DataAnnotations;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    public class UserReviewVM
    {
        [Display(Name = "Користувач")]
        [Required(ErrorMessage = "Логін користувача обов'язковий для заповнення")]
        public string UserLogin { get; set; }
        [Required(ErrorMessage = "Текст відгуку обов'язковий для заповнення")]
        [Display(Name = "Відгук")]
        public string ReviewText{ get; set; }
        [Display(Name = "Дата відгуку")]
        public DateTime ReviewDate { get;}

        public UserReviewVM()
        {
            ReviewDate = DateTime.Now;
        }
    }
}
