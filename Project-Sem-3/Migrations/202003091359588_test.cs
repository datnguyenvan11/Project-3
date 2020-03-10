namespace Project_Sem_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        InsuranceId = c.Int(nullable: false),
                        CreatedAt = c.Long(nullable: false),
                        UpdatedAt = c.Long(nullable: false),
                        DeletedAt = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Insurances", t => t.InsuranceId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.InsuranceId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        CreatedAt = c.Long(nullable: false),
                        UpdatedAt = c.Long(nullable: false),
                        DeletedAt = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HouseInsurances",
                c => new
                    {
                        InsurancePackageId = c.Int(nullable: false),
                        ContractId = c.Int(nullable: false),
                        HouseType = c.String(),
                        DurationHouse = c.String(),
                        HouseOwner = c.String(),
                        HouserAddress = c.String(),
                    })
                .PrimaryKey(t => new { t.InsurancePackageId, t.ContractId })
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .ForeignKey("dbo.InsurancePackages", t => t.InsurancePackageId, cascadeDelete: true)
                .Index(t => t.InsurancePackageId)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.InsurancePackages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InsuranceId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        DurationContract = c.String(),
                        DurationPay = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Insurances", t => t.InsuranceId, cascadeDelete: true)
                .Index(t => t.InsuranceId);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        DeleteAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MotorInsurances",
                c => new
                    {
                        InsurancePackageId = c.Int(nullable: false),
                        ContractId = c.Int(nullable: false),
                        CarOwner = c.String(),
                        RegisteredAddress = c.String(),
                        LicensePlate = c.String(),
                        ChassisNumber = c.String(),
                        Duration = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.InsurancePackageId, t.ContractId })
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .ForeignKey("dbo.InsurancePackages", t => t.InsurancePackageId, cascadeDelete: true)
                .Index(t => t.InsurancePackageId)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.HealthInsurances",
                c => new
                    {
                        InsurancePackageId = c.Int(nullable: false),
                        ContractId = c.Int(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        IdentityCard = c.String(),
                        DateOfIdentityCard = c.DateTime(nullable: false),
                        PlaceOfIdentityCard = c.String(),
                        Job = c.String(),
                    })
                .PrimaryKey(t => new { t.InsurancePackageId, t.ContractId })
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .ForeignKey("dbo.InsurancePackages", t => t.InsurancePackageId, cascadeDelete: true)
                .Index(t => t.InsurancePackageId)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.LifeInsurances",
                c => new
                    {
                        InsurancePackageId = c.Int(nullable: false),
                        ContractId = c.Int(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        IdentityCard = c.String(),
                        DateOfIdentityCard = c.DateTime(nullable: false),
                        PlaceOfIdentityCard = c.String(),
                        Job = c.String(),
                        MaritalStatus = c.String(),
                    })
                .PrimaryKey(t => new { t.InsurancePackageId, t.ContractId })
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .ForeignKey("dbo.InsurancePackages", t => t.InsurancePackageId, cascadeDelete: true)
                .Index(t => t.InsurancePackageId)
                .Index(t => t.ContractId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LifeInsurances", "InsurancePackageId", "dbo.InsurancePackages");
            DropForeignKey("dbo.LifeInsurances", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.HealthInsurances", "InsurancePackageId", "dbo.InsurancePackages");
            DropForeignKey("dbo.HealthInsurances", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Contracts", "InsuranceId", "dbo.Insurances");
            DropForeignKey("dbo.MotorInsurances", "InsurancePackageId", "dbo.InsurancePackages");
            DropForeignKey("dbo.MotorInsurances", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.InsurancePackages", "InsuranceId", "dbo.Insurances");
            DropForeignKey("dbo.HouseInsurances", "InsurancePackageId", "dbo.InsurancePackages");
            DropForeignKey("dbo.HouseInsurances", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Contracts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.LifeInsurances", new[] { "ContractId" });
            DropIndex("dbo.LifeInsurances", new[] { "InsurancePackageId" });
            DropIndex("dbo.HealthInsurances", new[] { "ContractId" });
            DropIndex("dbo.HealthInsurances", new[] { "InsurancePackageId" });
            DropIndex("dbo.MotorInsurances", new[] { "ContractId" });
            DropIndex("dbo.MotorInsurances", new[] { "InsurancePackageId" });
            DropIndex("dbo.InsurancePackages", new[] { "InsuranceId" });
            DropIndex("dbo.HouseInsurances", new[] { "ContractId" });
            DropIndex("dbo.HouseInsurances", new[] { "InsurancePackageId" });
            DropIndex("dbo.Contracts", new[] { "InsuranceId" });
            DropIndex("dbo.Contracts", new[] { "CustomerId" });
            DropTable("dbo.LifeInsurances");
            DropTable("dbo.HealthInsurances");
            DropTable("dbo.MotorInsurances");
            DropTable("dbo.Insurances");
            DropTable("dbo.InsurancePackages");
            DropTable("dbo.HouseInsurances");
            DropTable("dbo.Customers");
            DropTable("dbo.Contracts");
        }
    }
}
