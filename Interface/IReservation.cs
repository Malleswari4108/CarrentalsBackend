using Microsoft.AspNetCore.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Interface
{
    public interface IReservation
    {
        public Task<ActionResult<IEnumerable<Reservation>>> GetReservation();

        public Task<ActionResult<Reservation>> GetReservation(int id);

        public Task<ActionResult<Reservation>> PutReservation(int id, Reservation reservation);


        public Task<ActionResult<Reservation>> PostReservation(Reservation reservation);
        public Task<ActionResult<Reservation>> DeleteReservation(int id);
        bool ReservationExists(int id);
    }
}
