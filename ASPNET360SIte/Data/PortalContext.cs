using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNET360SIte.Models.IdentityCustomisationTest.Models;

namespace ASPNET360SIte.Models
{
    public class PortalContext : DbContext
    {
        public PortalContext (DbContextOptions<PortalContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNET360SIte.Models.IdentityCustomisationTest.Models.Property> Property { get; set; }
    }
}
