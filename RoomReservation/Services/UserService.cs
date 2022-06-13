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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _repository.Create(user);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public UserDTO Get(int id)
        {
            return _mapper.Map<UserDTO>(_repository.Get(id));
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<UserDTO>>(_repository.GetAll());
        }

        public void Update(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _repository.Update(user);
        }
    }
}
