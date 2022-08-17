using IdentityTable.Authendication;
using IdentityTable.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Controllers
{
    //[Authorize(Roles = UserRoles.User)]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IGetAllUserList _getAllUserList;

        public UsersController(IGetAllUserList getAllUserList)
        {
            _getAllUserList = getAllUserList;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPassportPerson()
        {
            var responce = await _getAllUserList.GetAllUser();
            return Ok(responce);
        }
    }
}
