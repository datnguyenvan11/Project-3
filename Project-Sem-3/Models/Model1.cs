namespace Project_Sem_3.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Project_Sem_3.Models.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model6")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<InsurancePackage> InsurancePackages { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<HealthInsurance> HealthInsurances { get; set; }
        public DbSet<HouseInsurance> HouseInsurances { get; set; }
        public DbSet<LifeInsurance> LifeInsurances { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}