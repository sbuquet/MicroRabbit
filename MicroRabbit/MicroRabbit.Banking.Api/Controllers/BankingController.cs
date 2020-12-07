using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // Get api/banking
        [HttpGet]
        public ActionResult<Account> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
    }
}
