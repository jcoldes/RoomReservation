using RoomReservation.Databases;
using RoomReservation.Models;
using RoomReservation.Respositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Respositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly RoomReservationContext _context;

        public LocationRepository(RoomReservationContext context)
        {
            _context = context;
        }
        public void Create(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Locations.Remove(Get(id));
            _context.SaveChanges();
        }

        public Location Get(int id)
        {
            return _context.Locations.First(r => r.Id == id);
        }

        public IEnumerable<Location> GetAll()
        {
            return _context.Locations.ToList();
        }

        public void Update(Location location)
        {
            _context.Locations.Update(location);
            _context.SaveChanges();
        }
    }
}
