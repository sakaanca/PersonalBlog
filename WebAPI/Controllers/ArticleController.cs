using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.ArticlesDtos;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService ?? throw new ArgumentNullException(nameof(articleService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _articleService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _articleService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var result = await _articleService.Add(articleAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return CreatedAtAction(nameof(Get), new { id = result.Data.Articles.Id }, result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var result = await _articleService.Update(articleUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _articleService.Delete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return NoContent();
            }

            return BadRequest(result);
        }

        [HttpPut("incrementRead/{id}")]
        public async Task<IActionResult> IncrementRead(int id)
        {
            var result = await _articleService.IncrementRead(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }

            return BadRequest(result);
        }
    }
}
