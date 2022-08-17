using IdentityTable.Authendication;
using IdentityTable.IRepo;
using IdentityTable.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Repo
{
    public class GetChild : IGetChild
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GetChild(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        Task<List<UserViewModel>> IGetChild.GetChild()
        {
            
        }
    }
}
