using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelViewPj.Models;

namespace ModelViewPj.Data
{
    public class ModelViewPjContext : DbContext
    {
        public ModelViewPjContext (DbContextOptions<ModelViewPjContext> options)
            : base(options)
        {
        }

        public DbSet<ModelViewPj.Models.Movie> Movie { get; set; }
    }
}
