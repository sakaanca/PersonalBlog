using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.SiteIdentityDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteIdentityController : ControllerBase
    {
        private readonly ISiteIdentityService _siteIdentityService;
        private readonly IMapper _mapper;

        public SiteIdentityController(ISiteIdentityService siteIdentityService, IMapper mapper)
        {
            _siteIdentityService = siteIdentityService ?? throw new ArgumentNullException(nameof(siteIdentityService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _siteIdentityService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(SiteIdentityUpdateDto siteIdentityUpdateDto)
        {
            var result = await _siteIdentityService.Update(siteIdentityUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }
    }
}
