using AutoMapper;
using Gastos.DTOs.Users;
using Gastos.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gastos.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UserController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await context.Users.ToListAsync();
        }

        [HttpPost]
        //public async Task<ActionResult> Post([FromBody] InsertDTO user)
        public async Task<ActionResult> Post([FromBody] User user)
        {
            try
            {
                bool exists = await context.Users.AnyAsync(u => u.Name == user.Name);

                if(!exists)
                {
                    //User newUser = mapper.Map<User>(user);
                    context.Add(user);
                    await context.SaveChangesAsync();
                    return Ok(user);
                }

                return BadRequest("El usuario ya existe");
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
