
namespace meal_sharing_entityframework;
public interface IReviewRepository
{
    Task<IEnumerable<Review>> ListReviews();
    Task AddReview(Review review);
    Task<List<Review>> GetMealReviews(int mealId);
    Task UpdateReview(Review review);
    Task DeleteReview(int id);
}