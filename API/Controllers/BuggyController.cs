using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseAPIController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret(){
            // end point
            return "secret text";
        }
        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound(){
            // end point
            var thing = _context.Users.Find(-1);
            if(thing == null) return NotFound();

            return thing;
        }
        [HttpGet("server-error")]
        public ActionResult<string> GetServerError(){
            // end point
            try{
                var thing = _context.Users.Find(-1);
                var thingToReturn = thing.ToString();
                return thingToReturn;
            }catch(Exception ex){
                return StatusCode(500, "Computer says no!");
            }

        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest(){
            // end point
            return BadRequest("This was not a good request");
        }

    }
}