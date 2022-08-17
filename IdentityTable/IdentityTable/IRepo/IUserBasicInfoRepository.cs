using IdentityTable.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.IRepo
{
    public interface IUserBasicInfoRepository
    {
        Task<string> CreateUser(UserBasicInfoViewModel userBasicInfoViewModel);
    }
}
