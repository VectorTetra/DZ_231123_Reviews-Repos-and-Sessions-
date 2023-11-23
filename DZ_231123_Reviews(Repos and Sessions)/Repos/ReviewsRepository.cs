using DZ_231123_Reviews_Repos_and_Sessions_.Models;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Repos
{
    public class ReviewsRepository : IRepository
    {
        private readonly ReviewContext _context;
        public ReviewsRepository(ReviewContext context)
        {
            _context = context;
        }

        public Task<List<UserReviewVM>> GetReviews() { }
        public Task<List<User>> GetUsers() { }
        public Task<User> FindUser(int id) { }
        public Task CreateReview(UserReviewVM reviewVM) { }
        public Task<bool> TryToRegister(RegisterVM registerVM) { }
        public Task<bool> TryToLogin(LoginVM loginVM) { }
    }
}
