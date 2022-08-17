using IdentityTable.Authendication;
using IdentityTable.IRepo;
using IdentityTable.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Repo
{
    public class GetAllUserList : IGetAllUserList
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GetAllUserList(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<UserViewModel>> GetAllUser()
        {
            List<UserViewModel> userViewModels =await _applicationDbContext.Users.OrderBy(x => x.Id).Select((a) => new UserViewModel
            {

                UserName = a.UserName,
                Email = a.Email,
            }).ToListAsync();

            return userViewModels;
        }
    }
}
