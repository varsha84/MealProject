namespace meal_sharing_entityframework;

public interface IMealRepository
{
    Task AddMeal(Meal meal);
    Task<IEnumerable<Meal>> MealsList();
    Task<Meal> GetMealById(int id);
    Task DeleteMeal(int id);
    Task UpdateMeal(Meal meal);
}