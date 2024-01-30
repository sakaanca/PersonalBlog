using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Entities.Dtos.AdminDtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminApiController(IAdminService adminService)
        {
            _adminService = adminService ?? throw new ArgumentNullException(nameof(adminService));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _adminService.Get(id);
            return result.ResultStatus switch
            {
                ResultStatus.Success => Ok(result),
                _ => BadRequest(result),
            };
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(AdminUpdateDto adminUpdateDto)
        {
            var result = await _adminService.Update(adminUpdateDto);
            return result.ResultStatus switch
            {
                ResultStatus.Success => Ok(result),
                _ => BadRequest(result),
            };
        }
    }

}
