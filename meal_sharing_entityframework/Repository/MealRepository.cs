using System.Collections.Generic;
using System.Linq;
using meal_sharing_entityframework;
using meal_sharing_entityframework.Data;
using Microsoft.EntityFrameworkCore;

public class MealRepository: IMealRepository {

    private readonly AppDbContext _context;



    public MealRepository(AppDbContext context)
    {
        _context = context;
    }
     public async Task AddMeal(Meal meal)
    {
         var value = _context.Meals.Add(meal);
        var result = _context.SaveChanges();

    }

    public async Task DeleteMeal(int id)
    {
        var meal = _context.Meals.Find(id);
        if (meal != null) {
            _context.Meals.Remove(meal);
        }
        _context.SaveChanges();
    }

    public async Task<Meal> GetMealById(int id)
    {
        var meal =  _context.Meals.Find(id);
        _context.SaveChanges();
        return meal;
    }
    public async Task<IEnumerable<Meal>> MealsList()
    {
        var mealList = _context.Meals.ToList();
        _context.SaveChanges();
        return mealList;
    }
    public async Task UpdateMeal(Meal meal)
    {
        var updateMeal = _context.Meals.Update(meal);
        _context.SaveChanges();

    }
}



   

   
 