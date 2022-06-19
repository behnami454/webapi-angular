using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Data
{
    public class CupsContext : DbContext
    {
        public CupsContext(DbContextOptions<CupsContext> options) : base(options) { }

        public DbSet<Cups> Cups { get; set; }
    }
}
