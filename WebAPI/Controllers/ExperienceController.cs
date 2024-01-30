using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.ExperiencesDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        private readonly IExperiencesService _experiencesService;
        private readonly IMapper _mapper;

        public ExperienceController(IExperiencesService experiencesService, IMapper mapper)
        {
            _experiencesService = experiencesService ?? throw new ArgumentNullException(nameof(experiencesService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _experiencesService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _experiencesService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(ExperiencesAddDto experiencesAddDto)
        {
            var result = await _experiencesService.Add(experiencesAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return CreatedAtAction(nameof(Get), new { id = result.Data.Experiences.Id }, result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(ExperiencesUpdateDto experiencesUpdateDto)
        {
            var result = await _experiencesService.Update(experiencesUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _experiencesService.Delete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _experiencesService.HardDelete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }
    }
}
