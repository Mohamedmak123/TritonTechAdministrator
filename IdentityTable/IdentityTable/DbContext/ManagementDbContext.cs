using IdentityTable.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTable.DBContext
{
    public class ManagementDbContext : DbContext 
    {
        public ManagementDbContext(DbContextOptions<ManagementDbContext> options) : base(options)
        {

        }
        public DbSet<UserBasicInfo> UserBasicInfo { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
