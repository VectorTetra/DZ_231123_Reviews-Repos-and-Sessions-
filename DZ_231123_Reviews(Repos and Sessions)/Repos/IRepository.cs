using DZ_231123_Reviews_Repos_and_Sessions_.Models;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Repos
{
    public interface IRepository
    {
        Task<List<Review>> GetReviews();
        Task<List<User>> GetUsers();
        Task<User> FindUser(int id);
        Task CreateReview(UserReviewVM reviewVM);
        Task CreateUser(RegisterVM registerVM);
        Task<bool> TryToLogin(LoginVM loginVM);
    }
}
