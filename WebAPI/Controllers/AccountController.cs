using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Entities.Dtos.Accounts;
using PersonalBlog.Service.Abstract;
using PersonalBlog.Shared.Utilities.ComplexTypes;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _accountService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _accountService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAllByNonDelete")]
        public async Task<IActionResult> GetAllByNonDelete()
        {
            var result = await _accountService.GetAllByNonDelete();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getAllByNonDeleteAndActive")]
        public async Task<IActionResult> GetAllByNonDeleteAndActive()
        {
            var result = await _accountService.GetAllByNonDeleteAndActive();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AccountsAddDto accountsAddDto)
        {
            var result = await _accountService.Add(accountsAddDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(AccountsUpdateDto accountsUpdateDto)
        {
            var result = await _accountService.Update(accountsUpdateDto);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _accountService.Delete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }

            return BadRequest(result);
        }

        [HttpDelete("hardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _accountService.HardDelete(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }

            return BadRequest(result);
        }
    }
}
