using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPNET360SIte.Models
{
    public class ASPNET360SIteContext : DbContext
    {
        public ASPNET360SIteContext (DbContextOptions<ASPNET360SIteContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET360SIte.Models.FloorPlan> FloorPlan { get; set; }
    }
}
