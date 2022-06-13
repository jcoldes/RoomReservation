﻿using RoomReservation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Services.Interfaces
{
    public interface IMeetingService
    {
        MeetingDTO Get(int id);
        IEnumerable<MeetingDTO> GetAll();
        void Create(MeetingDTO meetingDto);
        void Update(MeetingDTO meetingDto);
        void Delete(int id);
    }
}
