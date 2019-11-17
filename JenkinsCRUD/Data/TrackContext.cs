using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JenkinsCRUD.Models;

    public class TrackContext : DbContext
    {
        public TrackContext (DbContextOptions<TrackContext> options)
            : base(options)
        {
        }

        public DbSet<Track> Track { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Track>().ToTable("Track");
    }
}
