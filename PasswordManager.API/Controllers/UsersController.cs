using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Core.Entities;
using PasswordManager.Core.Interfaces;

namespace PasswordManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public IReadOnlyCollection<Users> GetUsers()
        {
            return _service.GetAll();
        }

        [HttpGet("signIn")]
        public IActionResult SignIn([FromRoute] string username, [FromRoute] string password)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = _service.SignIn(username, password);

            if (user is null) return NotFound();

            return Ok(user);
        }
    }
}