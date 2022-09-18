using AutoMapper;
using Gastos.DTOs.Accounts;
using Gastos.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gastos.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AccountController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("user")]
        public async Task<ActionResult> Post([FromBody] InsertDTO account)
        {
            bool exists = await context.Users.AnyAsync(x => x.Id == account.User.Id);

            if (exists)
            {
                exists = await context.Accounts.AnyAsync(x => x.Name == account.Name);

                if(!exists)
                {
                    Account newAccount = mapper.Map<Account>(account);

                    context.Add(newAccount);
                    await context.SaveChangesAsync();
                    return Ok(newAccount);
                }

                return BadRequest($"La cuenta {account.Name} ya existe");
            }

            return BadRequest($"El usuario {account.User.Id} no existe");
        }
    }
}
