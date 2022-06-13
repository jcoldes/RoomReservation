using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DTOs
{
    public class MeetingDTO
    {
        public int Id { get; set; }
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<Invitation> Invitations { get; set; }
    }
}
