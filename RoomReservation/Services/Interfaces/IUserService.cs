using RoomReservation.DTOs;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Services.Interfaces
{
    public interface IUserService
    {
        UserDTO Get(int Id);
        IEnumerable<UserDTO> GetAll();
        void Create(UserDTO userDto);
        void Update(UserDTO userDto);
        void Delete(int Id);
    }
}
