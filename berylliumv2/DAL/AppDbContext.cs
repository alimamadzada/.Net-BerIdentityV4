using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using berylliumv2.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace berylliumv2.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<ArchitectureImage> ArchitectureImages { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
