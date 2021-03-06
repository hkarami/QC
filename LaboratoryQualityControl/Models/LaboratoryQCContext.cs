﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryQualityControl.Models.Devices;

namespace LaboratoryQualityControl.Models
{
    public class LaboratoryQCContext : DbContext
    {
        public LaboratoryQCContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<DeviceModel> Devices { get; set; }
        public DbSet<LaboratorySectionModel> LaboratorySections { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<LogBookDevice> LogBookDevices { get; set; }
        public DbSet<LocationService> LocationServices { get; set; }
        public DbSet<ServiceDevice> ServiceDevices { get; set; }
        public DbSet<DeviceMaintenance> DeviceMaintenances { get; set; }
        public DbSet<AutoclaveQualityControl> AutoclaveQualityControls { get; set; }
        public DbSet<IncubatorMaintenance> IncubatorMaintenances { get; set; }
        public DbSet<LaboratoryQualityControl.Models.WaterBathMaintenance> WaterBathMaintenance { get; set; }
        public DbSet<SpectrophotometerMaintenance> SpectrophotometerMaintenances { get; set; }
        public DbSet<PhotometerMaintenance> PhotometerMaintenances { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<EducationalCertificate> EducationalCertificates { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatuses { get; set; }
        public DbSet<DeviceTypeModel> DeviceTypes { get; set; }
        public DbSet<DeviceStatus> DeviceStatuses { get; set; }
        public DbSet<SupportCompany> SupportCompanies { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<RulesQC> RulesQCs { get; set; }
        //public DbSet<Analyte> Analytes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<AnalyteMaterial> AnalyteMaterials { get; set; }
        public DbSet<LaboratoryQualityControl.Models.BloodControl> BloodControl { get; set; }

    }
}
