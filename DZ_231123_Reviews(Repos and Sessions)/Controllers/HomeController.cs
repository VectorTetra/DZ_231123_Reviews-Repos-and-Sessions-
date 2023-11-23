using DZ_231123_Reviews_Repos_and_Sessions_.Models;
using DZ_231123_Reviews_Repos_and_Sessions_.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Controllers
{
    public class HomeController : Controller
    {
        
        private IRepository repo;

        public HomeController(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var Reviews = await repo.GetReviews();
            return View(Reviews);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromForm] string Login, [FromForm] string ReviewText, IEnumerable<UserReviewVM> Reviews)
        {
            UserReviewVM userReviewVM = new() { ReviewText = ReviewText, UserLogin = Login, ReviewDate = DateTime.Now };
            await repo.CreateReview(userReviewVM);
            return View(Reviews);
        }
    }
}