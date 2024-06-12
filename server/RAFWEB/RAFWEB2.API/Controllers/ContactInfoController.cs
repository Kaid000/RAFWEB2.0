using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact;
using RAFWEB2.Domain.Domain.Contacts.Commands.DeleteContact;
using RAFWEB2.Domain.Domain.Contacts.Commands.UpdateContact;
using RAFWEB2.Domain.Domain.Contacts.Queries.GetAllContacts;
using RAFWEB2.Domain.Domain.Contacts.Queries.GetContactById;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInfoController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly IMapper _mapper;

        public ContactInfoController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        ///     Get all Contacts
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal Server error</response>
        [HttpGet]
        public async Task<List<ContactInfo>> GetAllContacts()
        {
            return await _mediator.Send(new GetAllContactsQuery());
        }

        /// <summary>
        ///     Get Contact by id
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal Server error</response>
        [HttpGet("id")]
        public async Task<ContactInfo> GetContactById(Guid id)
        {
            return await _mediator.Send(new GetContactByIdQuery(id));
        }

        /// <summary>
        ///     Add Contact to database
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal Server error</response>
        [HttpPost]
        public async Task<ContactInfo> AddContact(ContactInfoDTO contact)
        {
            var mapcontact = _mapper.Map<ContactInfoDTO, ContactInfo>(contact);
            return await _mediator.Send(new AddContactCommand(mapcontact));
        }

        /// <summary>
        ///    Change info about book
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal Server error</response>
        [HttpPut("{Contact}")]
        public async Task<ContactInfo> UpdateContact(ContactInfoDTO contact)
        {
            var mapcontact = _mapper.Map<ContactInfoDTO, ContactInfo>(contact);
            return await _mediator.Send(new UpdateContactCommand(mapcontact));
        }

        /// <summary>
        ///    Remove a contact from database
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal Server error</response>
        [HttpDelete("{Contact}")]
        public async Task<ContactInfo> DeleteContact(ContactInfoDTO contact)
        {
            var mapcontact = _mapper.Map<ContactInfoDTO, ContactInfo>(contact);
            return await _mediator.Send(new DeleteContactCommand(mapcontact));
        }
    }
}
