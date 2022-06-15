using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UMS.API.Models;

namespace UMS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController
    {

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Enumerable.Range(1, 10).Select(i => new User {Id = Guid.NewGuid(), Name = $"Name {i}"});
        }
    }
}