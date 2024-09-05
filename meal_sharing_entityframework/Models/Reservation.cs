
using Microsoft.AspNetCore.Http.HttpResults;

public class Reservation{
    public int Id { get; set; }
    public int MealId { get; set; }
    public string Name { get; set; }
    public string MobileNo {get; set; }
    public string Email { get; set; }
    public DateTime ReservationDate { get; set; }
    public int NumOfPerson { get; set; }
    
}
