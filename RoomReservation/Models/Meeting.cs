using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Room { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public IEnumerable<Invitation> Invitations { get; set; }
    }
}
