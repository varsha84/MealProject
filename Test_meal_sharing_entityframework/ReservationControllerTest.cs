using meal_sharing_entityframework;
using Moq;
using System.Threading.Tasks;

namespace Test_meal_sharing_entityframework
{
    public class ReservationTest
    {
        [Fact]
        public void GetReservationListTest()
        {
            // Arrange
            var mockReservationService = new Mock<IReservationRepository>();
            mockReservationService.Setup(x => x.ListReservations())
                .Returns(GetTestReservations());
            var controller = new ReservationController(mockReservationService.Object);

            // Act
            var results = controller.GetReservations();

            // Assert
            Assert.NotNull(results);
        }

        private async Task<IEnumerable<Reservation>> GetTestReservations()
        {
            return new List<Reservation>
        {
            new Reservation { Id =  1, MealId = 1, Name = "varsha", MobileNo = "3456789", Email= "varsha@gmail.com", ReservationDate = new DateTime(2024,6,15, 20, 49, 42), NumOfPerson = 4 } ,
            new Reservation { Id =  1, MealId = 2, Name = "sanju", MobileNo = "2345678", Email= "sanju@gmail.com", ReservationDate = new DateTime(2024,7,15, 20, 49, 42), NumOfPerson = 3 }
        };
        }
    }
}

    

