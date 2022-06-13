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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _repository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(RoomDTO roomDto)
        {
            _repository.Create(_mapper.Map<Room>(roomDto));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public RoomDTO Get(int id)
        {
            return _mapper.Map<RoomDTO>(_repository.Get(id));
        }

        public IEnumerable<RoomDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<RoomDTO>>(_repository.GetAll());
        }

        public void Update(RoomDTO roomDto)
        {
            _repository.Update(_mapper.Map<Room>(roomDto));
        }
    }
}
