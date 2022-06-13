using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
    }
}
