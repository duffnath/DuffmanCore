using DuffManCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuffManCore.Data
{
    public class LitterDbContext : DbContext
    {
        public LitterDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Litter> Litters { get; set; }
    }
}
