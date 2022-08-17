using IdentityTable.IRepo;
using IdentityTable.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Controllers.UserBasicInfo
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserBasicInfoController : ControllerBase
    {
        private readonly IUserBasicInfoRepository mUserBasicInfoRepository;

        public UserBasicInfoController(IUserBasicInfoRepository iUserBasicInfoRepository)
        {
            mUserBasicInfoRepository= iUserBasicInfoRepository
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserBasicInfoViewModel userBasicInfoViewModel)
        {
            var respose = await mUserBasicInfoRepository.CreateUser(userBasicInfoViewModel);
            if(respose == null)
            {
                return NoContent();
            }
            return Ok(respose);
        }
    }
}
