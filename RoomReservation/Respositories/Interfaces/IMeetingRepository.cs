using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Respositories.Interfaces
{
    public interface IMeetingRepository
    {
        Meeting Get(int id);
        IEnumerable<Meeting> GetAll();
        void Create(Meeting user);
        void Update(Meeting user);
        void Delete(int id);
    }
}
