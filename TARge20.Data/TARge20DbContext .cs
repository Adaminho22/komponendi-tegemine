using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<HealthCheck> healthChecks { get; set; }
        public DbSet<Hints> hints { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<SickLeave> sickLeaves { get; set; }
        public DbSet<Vacation> vacations { get; set; }
        public DbSet<Ward> wards { get; set; }
        public DbSet<WishList> wishLists { get; set; }
    }
}