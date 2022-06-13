using RoomReservation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Services.Interfaces
{
    public interface ILocationService
    {
        LocationDTO Get(int id);
        IEnumerable<LocationDTO> GetAll();
        void Create(LocationDTO invitation);
        void Update(LocationDTO invitation);
        void Delete(int id);
    }
}
