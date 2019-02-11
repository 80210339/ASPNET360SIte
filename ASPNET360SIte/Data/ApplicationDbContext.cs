using System;
using System.Collections.Generic;
using System.Text;
using ASPNET360SIte.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNET360SIte.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET360SIte.Models.Property> Property { get; set; }

        public DbSet<ASPNET360SIte.Models.FloorPlan> FloorPlan { get; set; }

        public DbSet<ASPNET360SIte.Models.Room> Room { get; set; }
    }
}
