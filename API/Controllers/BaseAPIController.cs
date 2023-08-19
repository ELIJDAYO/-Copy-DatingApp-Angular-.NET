using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController] 
    [Route("api/[controller]")] // GET .../api/users, is used to access this controller, endpoint

    public class BaseAPIController : ControllerBase
    {
        
    }
}