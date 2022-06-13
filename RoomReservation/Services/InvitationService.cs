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
    public class InvitationService : IInvitationService
    {
        private readonly IInvitationRepository _repository;
        private readonly IMapper _mapper;

        public InvitationService(IInvitationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(InvitationDTO invitationDto)
        {
            var invitation = _mapper.Map<Invitation>(invitationDto);
            _repository.Create(invitation);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public InvitationDTO Get(int id)
        {
            return _mapper.Map<InvitationDTO>(_repository.Get(id));
        }

        public IEnumerable<InvitationDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<InvitationDTO>>(_repository.GetAll());
        }

        public void Update(InvitationDTO invitationDto)
        {
            _repository.Update(_mapper.Map<Invitation>(invitationDto));
        }
    }
}
