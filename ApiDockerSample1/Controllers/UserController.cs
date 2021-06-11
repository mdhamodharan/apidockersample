using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDockerSample1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {

        }

        [HttpGet]
        [Route("getusers")]
        public IActionResult GetAllUsers()
        {
            string[] userList = new string[2];
            userList[0] = "User One";
            userList[1] = "User Two";
            return Ok(userList);
        }

    }
}
