using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController] 
    [Route("api/[controller]")] // GET .../api/users, is used to access this controller, endpoint
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context){
            _context = context;
            
        }
        [HttpGet]
        // return list of users
        public ActionResult<IEnumerable<AppUser>> GetUsers(){
            var users = _context.Users.ToList();

            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id){
            var user = _context.Users.Find(id);

            return user;
        }
    }
}