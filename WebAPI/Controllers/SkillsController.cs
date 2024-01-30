using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.SkillsDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsService _skillsService;
        private readonly IMapper _mapper;

        public SkillsController(ISkillsService skillsService, IMapper mapper)
        {
            _skillsService = skillsService ?? throw new ArgumentNullException(nameof(skillsService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _skillsService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _skillsService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(SkillsAddDto skillsAddDto)
        {
            var result = await _skillsService.Add(skillsAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return CreatedAtAction(nameof(Get), new { id = result.Data.Skills.Id }, result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(SkillsUpdateDto skillsUpdateDto)
        {
            var result = await _skillsService.Update(skillsUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _skillsService.Delete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _skillsService.HardDelete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }
    }
}
