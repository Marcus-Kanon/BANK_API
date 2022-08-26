using Microsoft.AspNetCore.Mvc;

namespace BANK_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Deposit/{amount}")]
        public bool Deposit(decimal amount)
        {
            return Account.Deposit(amount);
        }


        [HttpGet("Withdraw/{amount}")]
        public bool Withdraw(decimal amount)
        {
            return Account.Withdraw(amount);
        }


        [HttpGet("Balance")]
        public decimal Balance()
        {
            return Account.Balance;
        }
    }
}