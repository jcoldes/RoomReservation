using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Respositories.Interfaces
{
    public interface IRoomRepository
    {
        Room Get(int id);
        IEnumerable<Room> GetAll();
        void Create(Room user);
        void Update(Room user);
        void Delete(int id);
    }
}
