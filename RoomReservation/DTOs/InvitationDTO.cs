using RoomReservation.Common.Enums;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DTOs
{
    public class InvitationDTO
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Meeting Meeting { get; set; }
        public AttendeeStatus Status { get; set; }
    }
}
