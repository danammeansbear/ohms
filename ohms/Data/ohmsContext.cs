#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ohms.Models;

namespace ohms.Data
{
    public class ohmsContext : DbContext
    {
        public ohmsContext (DbContextOptions<ohmsContext> options)
            : base(options)
        {
        }

        public DbSet<ohms.Models.ohmsClass> ohmsClass { get; set; }
    }
}
