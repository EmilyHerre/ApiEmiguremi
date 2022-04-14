using ApiEmiguremi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmiguremi.Services
{
    public class EmiguremiDbContext : DbContext
    {
        public EmiguremiDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ProyectItem> ProyectItems { get; set; }
        
    }
}
