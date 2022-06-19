using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public class LegendsContext : DbContext
    {
        public LegendsContext(DbContextOptions<LegendsContext> options) : base(options) { }

        public DbSet<Legends> Legends { get; set; }
    }
}
