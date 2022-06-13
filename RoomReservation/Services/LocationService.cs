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
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _repository;
        private readonly IMapper _mapper;

        public LocationService(ILocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(LocationDTO locationDto)
        {
            _repository.Create(_mapper.Map<Location>(locationDto));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public LocationDTO Get(int id)
        {
            return _mapper.Map<LocationDTO>(_repository.Get(id));
        }

        public IEnumerable<LocationDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<LocationDTO>>(_repository.GetAll());
        }

        public void Update(LocationDTO locationDto)
        {
            _repository.Update(_mapper.Map<Location>(locationDto));
        }
    }
}
