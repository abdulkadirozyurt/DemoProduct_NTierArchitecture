using Entites.Concretes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class NTierArchitectureContext : IdentityDbContext<AppUser, AppRole, int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=abdulkadirF17; database=UdemyNTierArchitecture;integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }

    }
}



// this class will create database with tables that we name and map out entities to tables


/*IdentityDbContext<AppUser, AppRole, int>
 
 identity ye karşılık gelen user tablosunu entity olarak veriyoruz, yani AppUser entity'sinin field'ları + IdentityUser'ın fieldları olmuş oluyor. Aynı şekilde role için de öyle
 
 
 */
 