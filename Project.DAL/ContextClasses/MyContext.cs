using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new EmployeeProfileMap());
            modelBuilder.Configurations.Add(new ExtraProductMap());
            modelBuilder.Configurations.Add(new ExtraProductPossibleProplemMap());
            modelBuilder.Configurations.Add(new PossibleProblemMap());
            modelBuilder.Configurations.Add(new ProductPossibleProblemMap());
            modelBuilder.Configurations.Add(new ProductDetailMap());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<ExtraProduct> ExtraProducts { get; set; }
        public DbSet<ExtraProductPossibleProblem> extraProductPossibleProblems { get; set; }
        public DbSet<PossibleProblem> PossibleProblems { get; set; }
        public DbSet<ProductPossibleProblem> ProductPossibleProblems { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
