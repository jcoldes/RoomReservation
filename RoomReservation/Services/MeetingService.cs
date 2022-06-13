using AutoMapper;
using RoomReservation.DTOs;
using RoomReservation.Models;
using RoomReservation.Respositories.Interfaces;
using RoomReservation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Services
{
    public class MeetingService : IMeetingService
    {
        private readonly IMeetingRepository _repository;
        private readonly IMapper _mapper;

        public MeetingService(IMeetingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(MeetingDTO meetingDto)
        {
            _repository.Create(_mapper.Map<Meeting>(meetingDto));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public MeetingDTO Get(int id)
        {
            return _mapper.Map<MeetingDTO>(_repository.Get(id));
        }

        public IEnumerable<MeetingDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<MeetingDTO>>(_repository.GetAll());
        }

        public void Update(MeetingDTO meetingDto)
        {
            _repository.Update(_mapper.Map<Meeting>(meetingDto));
        }
    }
}
