using AutoMapper;
using RoomReservation.DTOs;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<LocationDTO, Location>().ReverseMap();
            CreateMap<MeetingDTO, Meeting>().ReverseMap();
            CreateMap<RoomDTO, Room>().ReverseMap();
        }
    }
}
