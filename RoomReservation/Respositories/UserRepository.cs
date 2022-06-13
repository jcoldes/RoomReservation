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
    public class UserRepository : IUserRepository
    {
        private readonly RoomReservationContext _context;

        public UserRepository(RoomReservationContext context)
        {
            _context = context;
        }
        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Users.Remove(Get(id));
            _context.SaveChanges();
        }

        public User Get(int id)
        {
            return _context.Users.First(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
