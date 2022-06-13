using RoomReservation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Services.Interfaces
{
    public interface IRoomService
    {
        RoomDTO Get(int id);
        IEnumerable<RoomDTO> GetAll();
        void Create(RoomDTO invitation);
        void Update(RoomDTO invitation);
        void Delete(int id);
    }
}
