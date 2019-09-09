using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models;

namespace LaboratoryQualityControl.Models
{
    public class LaboratoryQCContext : DbContext
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
        public DbSet<LocationService> locationServices { get; set; }
        public DbSet<ServiceDevice> serviceDevices { get; set; }
        public DbSet<DeviceMaintenance> deviceMaintenances { get; set; }
        public DbSet<AutoclaveQualityControl> autoclaveQualityControls { get; set; }
        public DbSet<IncubatorMaintenance> incubatorMaintenances { get; set; }
        public DbSet<LaboratoryQualityControl.Models.WaterBathMaintenance> WaterBathMaintenance { get; set; }
        public DbSet<SpectrophotometerMaintenance> SpectrophotometerMaintenances { get; set; }
        public DbSet<PhotometerMaintenance> PhotometerMaintenances { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<EducationalCertificate> EducationalCertificates { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatuses { get; set; }

    }
}
