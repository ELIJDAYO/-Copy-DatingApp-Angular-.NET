using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // validated by jwt token
    [Authorize]
    // send request from client to this controller

    public class UsersController : BaseAPIController
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        [HttpGet]
        // return list of users
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return Ok(await _userRepository.GetUsersAsync());

        }

        [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetUsers(string username)
        {
            return await _userRepository.GetUserByUsernameAsync(username);
        }
    }
}