using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mudasser.Shared;

namespace Mudasser.Server.Data
{
    public class MudasserServerContext : DbContext
    {
        public MudasserServerContext (DbContextOptions<MudasserServerContext> options)
            : base(options)
        {
        }

        public DbSet<Mudasser.Shared.Users> Users { get; set; } = default!;
    }
}
