using IdentityTable.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.IRepo
{
    public interface IGetAllUserList
    {
        Task<List<UserViewModel>> GetAllUser();
    }
}
