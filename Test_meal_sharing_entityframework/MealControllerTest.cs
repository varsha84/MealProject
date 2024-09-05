using meal_sharing_entityframework;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Test_meal_sharing_entityframework
{
    public class MealTest
    {

        [Fact]
        public void GetMealListTest()
        {
            // Arrange
            var mockMealService = new Mock<IMealRepository>();
            mockMealService.Setup(service => service.MealsList())
                .Returns(GetTestMeals());
            var controller = new MealController(mockMealService.Object);

            // Act
            var results = controller.MealsList();

            // Assert
            Assert.NotNull(results);

        }
        private async Task<IEnumerable<Meal>> GetTestMeals()
        {
            return new List<Meal>
            {
                new Meal { Id =  1, Title ="daal tadka", Description = "mild", Price = 234, ImageUrl= "djdd", Location= "ballerup", MaxReservation = 10, CreatedDate = new DateTime(2024,6,15, 20, 49, 42), WhenDate = new DateTime(2024,7,15,20,49,42) },
                new Meal { Id =  1, Title ="veg biryani", Description = "spicy", Price = 123, ImageUrl= "vds", Location= "smørum", MaxReservation = 13, CreatedDate = new DateTime(2024,6,15, 20, 49, 42), WhenDate = new DateTime(2024,7,15,20,49,42) }
            };
        }
    }
}