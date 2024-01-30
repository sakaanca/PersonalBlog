using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.AboutMeDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMeController : ControllerBase
    {
        private readonly IAboutMeService _aboutMeService;

        public AboutMeController(IAboutMeService aboutMeService)
        {
            _aboutMeService = aboutMeService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _aboutMeService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(AboutMeUpdateDto aboutMeUpdateDto)
        {
            var result = await _aboutMeService.Update(aboutMeUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }
    }
}
