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
    public class MeetingRepository : IMeetingRepository
    {
        private readonly RoomReservationContext _context;

        public MeetingRepository(RoomReservationContext context)
        {
            _context = context;
        }
        public void Create(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Meetings.Remove(Get(id));
            _context.SaveChanges();
        }

        public Meeting Get(int id)
        {
            return _context.Meetings.First(r => r.Id == id);
        }

        public IEnumerable<Meeting> GetAll()
        {
            return _context.Meetings.ToList();
        }

        public void Update(Meeting meeting)
        {
            _context.Meetings.Update(meeting);
            _context.SaveChanges();
        }
    }
}
