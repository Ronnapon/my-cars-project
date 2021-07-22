using Microsoft.EntityFrameworkCore;
using my_cars.Data.Models;
using my_cars.EntityConfigurations;

namespace my_cars.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new AdminConfiguration());
            modelBuilder.AddConfiguration(new AdminLoginConfiguration());
            modelBuilder.AddConfiguration(new CarConfiguration());
            modelBuilder.AddConfiguration(new CarBrandConfiguration());
            modelBuilder.AddConfiguration(new CarModelConfiguration());
            modelBuilder.AddConfiguration(new CustLoginConfiguration());
            modelBuilder.AddConfiguration(new CustomerConfiguration());
            modelBuilder.AddConfiguration(new EmpLoginConfiguration());
            modelBuilder.AddConfiguration(new EmployeeConfiguration());
            modelBuilder.AddConfiguration(new GarageConfiguration());
            modelBuilder.AddConfiguration(new ReasonConfiguration());
            modelBuilder.AddConfiguration(new TitleConfiguration());
            modelBuilder.AddConfiguration(new AppointmentConfiguration());
            modelBuilder.AddConfiguration(new AppointmentDetailConfiguration());
        }

        public DbSet<Admin> admins { get; set; }
        public DbSet<AdminLogin> adminLogins { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<CarBrand> carBrands { get; set; }
        public DbSet<CarModel> carModels { get; set; }
        public DbSet<CustLogin> custLogins { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<EmpLogin> empLogins { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Garage> garages { get; set; }
        public DbSet<Reason> reasons { get; set; }
        public DbSet<Title> titles { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<AppointmentDetail> appointmentDetails { get; set; }
    }
}
