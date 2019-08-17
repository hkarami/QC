using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryQualityControl.Models
{
    public class LaboratoryQCContext: DbContext
    {
        public LaboratoryQCContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Device> Devices { get; set; }
        public DbSet<LaboratorySections> LaboratorySections { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<LogBookDevice> logBookDevices { get; set; }
    }
}
