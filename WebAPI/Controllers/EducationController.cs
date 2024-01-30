using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.EducationDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly IEducationService _educationService;
        private readonly IMapper _mapper;

        public EducationController(IEducationService educationService, IMapper mapper)
        {
            _educationService = educationService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _educationService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _educationService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] EducationAddDto educationAddDto)
        {
            var result = await _educationService.Add(educationAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] EducationUpdateDto educationUpdateDto)
        {
            var result = await _educationService.Update(educationUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _educationService.Delete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }

            return BadRequest(result);
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _educationService.HardDelete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }

            return BadRequest(result);
        }
    }
}
