using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Respositories.Interfaces
{
    public interface IInvitationRepository
    {
        Invitation Get(int id);
        IEnumerable<Invitation> GetAll();
        void Create(Invitation user);
        void Update(Invitation user);
        void Delete(int id);
    }
}
