
using System.Collections.Generic;
using System.Threading.Tasks;
using meal_sharing_entityframework;

using meal_sharing_entityframework.Data;

public class ReviewRepository : IReviewRepository
{
    private readonly AppDbContext _context;
    public ReviewRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Review>> ListReviews()
    {
        return _context.Reviews.ToList();
       
    }
    public async Task AddReview(Review review)
    {
        _context.Reviews.Add(review);
        _context.SaveChanges();
    }
    public async Task<List<Review>> GetMealReviews(int id)
    {
        var review = _context.Reviews.Where(x => x.Id == id).ToList();
        if (review != null)
        {
            return review;
        }
        return new List<Review>(0);
    }
    public async Task UpdateReview(Review review)
    {
        _context.Reviews.Update(review);
        _context.SaveChanges();
    }
    public async Task DeleteReview( int id)
    {    
        var review = _context.Reviews.Find(id);
        if(review != null)
        {
            _context.Reviews.Remove(review);
        }
        _context.SaveChanges();
    }
}
    