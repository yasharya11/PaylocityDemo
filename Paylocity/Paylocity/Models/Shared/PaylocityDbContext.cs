using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaylocityCore.Entities;

namespace Paylocity.Models.Shared
{
    public class PaylocityDbContext : DbContext
    { 
        public PaylocityDbContext(DbContextOptions<PaylocityDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
        public DbSet<BenefitsModifier> BenefitModifiers { get; set; }
    }
}
