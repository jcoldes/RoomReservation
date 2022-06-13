using RoomReservation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Services.Interfaces
{
    public interface IInvitationService
    {
        InvitationDTO Get(int id);
        IEnumerable<InvitationDTO> GetAll();
        void Create(InvitationDTO invitation);
        void Update(InvitationDTO invitation);
        void Delete(int id);
    }
}
