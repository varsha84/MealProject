using Microsoft.AspNetCore.Mvc;
namespace meal_sharing_entityframework;

[ApiController]
[Route("api/reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }
    /* get All meals reservation */
    [HttpGet("")]
    public async Task<IEnumerable<Reservation>> GetReservations()
    {

        return await _repo.ListReservations();
    }
    /* Add meal reservation */
    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.AddReservation(r);
    }
    /* get meal reservation by meals*/
    [HttpGet("{id}")]
    public async Task <List<Reservation>> GetMealReservations(int id)
    {
        return await _repo.GetMealReservations(id);


    }
    /* update meal reservation */
    [HttpPut("{id}")]
    public async Task UpdateReservation(Reservation Reservation)
    {
        await _repo.UpdateReservation(Reservation);
    }
    /* delete meal reservation by meals*/
    [HttpDelete("{id}")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }

}