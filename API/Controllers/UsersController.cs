using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // send request from client to this controller

    public class UsersController : BaseAPIController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context){
            _context = context;
            
        }
        [HttpGet]
        // return list of users
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            var users = await _context.Users.ToListAsync();

            return users;
        }
 
        [HttpGet("{id}")]
        public async  Task<ActionResult<AppUser>> GetUsers(int id){
            var user = await _context.Users.FindAsync(id);

            return user;
        }
    }
}