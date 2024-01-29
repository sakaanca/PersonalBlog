using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.SummaryDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;
using PersonalBlog.Shared.Utilities.Concrete;

using AutoMapper;



namespace PersonalBlog.MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryController : ControllerBase
    {
        ISummaryService _summaryService;

        public SummaryController(ISummaryService summaryService)
        {
            _summaryService = summaryService;
        }
        [HttpPost("GetAsync")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await _summaryService.GetAsync(id);
            if (result.ResultStatus==ResultStatus.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(SummaryUpdateDto summaryUpdateDto)
        {
            

            var result = await _summaryService.UpdateAsync(summaryUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
