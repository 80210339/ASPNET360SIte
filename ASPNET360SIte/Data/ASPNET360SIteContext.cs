using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Models;

namespace ASPNET360SIte.Models
{
    public class ASPNET360SIteContext : DbContext
    {
        public ASPNET360SIteContext (DbContextOptions<ASPNET360SIteContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET360SIte.Models.Property> Property { get; set; }

        public DbSet<ASPNET360SIte.Models.FloorPlan> FloorPlan { get; set; }

        public DbSet<ASPNET360SIte.Models.Room> Room { get; set; }
    }
}
