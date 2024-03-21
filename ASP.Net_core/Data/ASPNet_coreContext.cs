using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.Net_core.Model;

namespace ASP.Net_core.Data
{
    public class ASPNet_coreContext : DbContext
    {
        public ASPNet_coreContext (DbContextOptions<ASPNet_coreContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.Net_core.Model.User> User { get; set; } = default!;
        public DbSet<ASP.Net_core.Model.Donhang> Donhang { get; set; } = default!;
    }
}
