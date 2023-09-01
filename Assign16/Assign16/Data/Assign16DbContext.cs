using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assign16.Models;

namespace Assign16.Data
{
    public class Assign16DbContext : DbContext
    {
        public Assign16DbContext (DbContextOptions<Assign16DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assign16.Models.Task> Task { get; set; } = default!;
    }
}
