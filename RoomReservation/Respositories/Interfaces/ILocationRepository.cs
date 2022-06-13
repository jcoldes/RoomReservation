using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Respositories.Interfaces
{
    public interface ILocationRepository
    {
        Location Get(int id);
        IEnumerable<Location> GetAll();
        void Create(Location user);
        void Update(Location user);
        void Delete(int id);
    }
}
