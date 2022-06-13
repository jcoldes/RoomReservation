using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Respositories.Interfaces
{
    public interface IUserRepository
    {
        User Get(int id);
        IEnumerable<User> GetAll();
        void Create(User user);
        void Update(User user);
        void Delete(int id);
    }
}
