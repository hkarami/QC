using Microsoft.EntityFrameworkCore;

namespace LaboratoryQualityControl.Domain
{
    public class LaboratoryQCContext : DbContext
    {
        public LaboratoryQCContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Device> Devices { get; set; }
        public DbSet<LaboratorySection> LaboratorySections { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<LogBookDevice> LogBookDevices { get; set; }
        public DbSet<LocationService> LocationServices { get; set; }
        public DbSet<ServiceDevice> ServiceDevices { get; set; }
        public DbSet<DeviceMaintenance> DeviceMaintenances { get; set; }
        public DbSet<AutoclaveQualityControl> AutoclaveQualityControls { get; set; }
        public DbSet<IncubatorMaintenance> IncubatorMaintenances { get; set; }
        public DbSet<WaterBathMaintenance> WaterBathMaintenance { get; set; }
        public DbSet<SpectrophotometerMaintenance> SpectrophotometerMaintenances { get; set; }
        public DbSet<PhotometerMaintenance> PhotometerMaintenances { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<EducationalCertificate> EducationalCertificates { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatuses { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<DeviceStatus> DeviceStatuses { get; set; }
        public DbSet<SupportCompany> SupportCompanies { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<RulesQC> RulesQCs { get; set; }
        public DbSet<Analyte> Analytes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<AnalyteMaterial> AnalyteMaterials { get; set; }
        public DbSet<BloodControl> BloodControl { get; set; }

    }
}
