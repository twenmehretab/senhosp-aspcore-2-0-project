﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SensenHosp.Models;

namespace SensenHosp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<BlogPostTag>()
            .HasKey(b => new { b.PostId, b.TagId });
        }


        // Start of code addition
        //Blog feature
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostTag> BlogPostsTags { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<SensenHosp.Models.Contact> Contact { get; set; }
        public DbSet<SensenHosp.Models.FreqAskQuestion> FreqAskQuestion { get; set; }
        public DbSet<SensenHosp.Models.AlertPosts> AlertPosts { get; set; }

        // Media feature
        public DbSet<Album> Albums { get; set; }
        public DbSet<Media> Media { get; set; }
        
        // Donation feature
        public DbSet<Donation> Donations { get; set; }
        // End of code addition
    }
}
