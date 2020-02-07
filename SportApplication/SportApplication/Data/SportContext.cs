using Microsoft.EntityFrameworkCore;
using SportApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Data
{
    public class SportContext : DbContext
    {
        public SportContext(DbContextOptions<SportContext> options) : base(options)
        {
        }

        public DbSet<Sport> Sports { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Contestant> Contestants { get; set; }
    }
}
