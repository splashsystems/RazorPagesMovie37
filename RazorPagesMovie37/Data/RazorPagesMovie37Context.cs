using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie37.Models;

namespace RazorPagesMovie37.Data
{
    public class RazorPagesMovie37Context : DbContext
    {
        public RazorPagesMovie37Context (DbContextOptions<RazorPagesMovie37Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie37.Models.Movie> Movie { get; set; }
    }
}
