using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransferLog>>> Get()
        {
            var transferLogs = await _transferService.GetTransferLogs();
            if (transferLogs == null) return BadRequest();
            if (!transferLogs.Any()) return NotFound();
            return Ok(transferLogs);
        }
    }
}