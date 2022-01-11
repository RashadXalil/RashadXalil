using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class PustokContext : DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders {get;set;}
        public DbSet<Features> Features { get; set; }
        public DbSet<Promotions> Promotions { get; set; }
    }
}
