using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransitAPI.Models.Data
{
    public class TirContext : DbContext
    {
        public TirContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transit> Transits { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
