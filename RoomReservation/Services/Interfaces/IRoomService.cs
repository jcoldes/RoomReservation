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
        void Create(RoomDTO roomDto);
        void Update(RoomDTO roomDto);
        void Delete(int id);
    }
}
