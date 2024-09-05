
using meal_sharing_entityframework;
using meal_sharing_entityframework.Data;


public class ReservationRepository : IReservationRepository
{
    private readonly AppDbContext _context;
    public ReservationRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task AddReservation(Reservation reservation)
    {
        var value =  _context.Reservations.Add(reservation);
        _context.SaveChanges();
    }

    public async Task<List<Reservation>> GetMealReservations(int id)
    {
        var meal =  _context.Reservations.Where(x => x.MealId == id).ToList();
        
            if (meal != null)
            {
                return meal;
                
            }
            else
            {
                 return new List<Reservation>(0);  
            }
    }
      
  
        
    public async Task<IEnumerable<Reservation>> ListReservations()
    {
        var listOfReservations =  _context.Reservations.ToList();
        _context.SaveChanges();
        return listOfReservations;

    }
    public async Task UpdateReservation(Reservation reservation)
    {
        var res = _context.Reservations.Update(reservation);
        _context.SaveChanges();

    }
    public async Task DeleteReservation(int id)
    {
        var reservation = _context.Reservations.Find(id);
        if (reservation != null)
        {
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }

    }


}

