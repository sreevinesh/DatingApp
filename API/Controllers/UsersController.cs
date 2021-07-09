using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using API.Data;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Controllers
{
   
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        } 

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<API.Entities.AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<API.Entities.AppUser>> GetUser(int id)
        {
             return await _context.Users.FindAsync(id);
        }
    }
}