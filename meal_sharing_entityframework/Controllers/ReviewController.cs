using Microsoft.AspNetCore.Mvc;
using meal_sharing_entityframework;
namespace meal_sharing_entityframework;

[ApiController]
[Route("api/reviews")]
public class ReviewController : ControllerBase
{
    private IReviewRepository _repo;

    public ReviewController(IReviewRepository repo)
    {
        _repo = repo;
    }
    /* All meals in Review */
    [HttpGet("")]
    public async Task<IEnumerable<Review>> ListReviews()
    {
        return await _repo.ListReviews();
    }
    /* add review for meal*/
    [HttpPost("")]
    public async Task AddReview([FromBody] Review review)
    {
        await _repo.AddReview(review);
    }
    /* get meal review by mealid*/
    [HttpGet("{mealid}")]
    public async Task <List<Review>> GetMealReviews(int mealid)
    {
        return await _repo.GetMealReviews(mealid);
    }
    /* upadate meal Review */
    [HttpPut("{mealid}")]
    public async Task UpdateReview(Review review)
    {
        await _repo.UpdateReview(review);
    }
    /* delete meal Review */
    [HttpDelete("{mealid}")]
    public async Task DeleteReview(int mealid)
    {
        await _repo.DeleteReview(mealid);
    }

}
