namespace meal_sharing_entityframework;

public class Review
{
    public int Id {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public int MealId {get; set;}
    public int Stars {get; set;}
    public DateTime CreatedDate { get; set;}
}