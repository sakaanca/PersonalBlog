using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.MessagesDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessagesController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _messageService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _messageService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(MessagesAddDto messagesAddDto)
        {
            var result = await _messageService.Add(messagesAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return CreatedAtAction(nameof(Get), new { id = result.Data.Messages.Id }, result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(MessagesUpdateDto messagesUpdateDto)
        {
            var result = await _messageService.Update(messagesUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _messageService.Delete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _messageService.HardDelete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }
    }
}
