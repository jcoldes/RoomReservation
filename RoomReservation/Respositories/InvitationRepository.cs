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
    public class InvitationRepository : IInvitationRepository
    {
        private readonly RoomReservationContext _context;

        public InvitationRepository(RoomReservationContext context)
        {
            _context = context;
        }
        public void Create(Invitation invitation)
        {
            _context.Invitations.Add(invitation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Invitations.Remove(Get(id));
            _context.SaveChanges();
        }

        public Invitation Get(int id)
        {
            return _context.Invitations.First(r => r.Id == id);
        }

        public IEnumerable<Invitation> GetAll()
        {
            return _context.Invitations.ToList();
        }

        public void Update(Invitation invitation)
        {
            _context.Invitations.Update(invitation);
            _context.SaveChanges();
        }
    }
}
