using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DTOs
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Meeting> Meetings { get; set; }
    }
}
