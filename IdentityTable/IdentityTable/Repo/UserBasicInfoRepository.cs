using IdentityTable.DBContext;
using IdentityTable.IRepo;
using IdentityTable.Models;
using IdentityTable.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.Repo
{
    public class UserBasicInfoRepository : IUserBasicInfoRepository
    {
        private readonly ManagementDbContext mDbContext;

        public UserBasicInfoRepository(ManagementDbContext iDbContext)
        {
            mDbContext = iDbContext;
        }
        public async Task<string> CreateUser(UserBasicInfoViewModel request)
        {
            List<Guid> UsersId = mDbContext.UserBasicInfo.Select(x => x.Id).ToList();
            UserBasicInfo userBasicInfo = new UserBasicInfo()
            {
                Id = request.Id,
                Name = request.Name,
                Age = request.Age,
                MobileNumber = request.MobileNumber,
                Address = request.Address,
                BloodGroup = request.BloodGroup,
                Email = request.Email,
                Gender = request.Gender,
                RoleId = request.RoleId,
                DateOfJoining = request.DateOfJoining,
                ReportingHeaderId = request.ReportingHeaderId,
                DateOfExit = request.DateOfExit
            };
            if (UsersId.Contains(request.Id))
            {
                mDbContext.UserBasicInfo.Update(userBasicInfo);
            }
            else
                await mDbContext.UserBasicInfo.AddAsync(userBasicInfo);
            await mDbContext.SaveChangesAsync();
            return "Added Successfully";
        }
    }
}
