using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> Get()
        {
            var accounts = await _accountService.GetAccounts();
            if (accounts == null) return BadRequest();
            if (!accounts.Any()) return NotFound();
            return Ok(accounts);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AccountTransfer accountTransfer)
        {
            if (accountTransfer == null) return BadRequest();
            await _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}