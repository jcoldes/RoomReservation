using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Databases
{
    public class RoomReservationContext : DbContext
    {
        public RoomReservationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Database=RoomReservation;integrated security=true;Persist Security Info=True;Connect Timeout=300;";
            optionsBuilder.UseSqlServer(connection);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
    }
}
