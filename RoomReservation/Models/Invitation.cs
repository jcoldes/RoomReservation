using RoomReservation.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class Invitation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Meeting Meeting { get; set; }
        [Required]
        public AttendeeStatus Status { get; set; }
    }
}
