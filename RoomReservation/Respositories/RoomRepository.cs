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
    public class RoomRepository : IRoomRepository
    {
        private readonly RoomReservationContext _context;

        public RoomRepository(RoomReservationContext context)
        {
            _context = context;
        }
        public void Create(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Rooms.Remove(Get(id));
            _context.SaveChanges();
        }

        public Room Get(int id)
        {
            return _context.Rooms.First(r => r.Id == id);
        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }

        public void Update(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }
    }
}
