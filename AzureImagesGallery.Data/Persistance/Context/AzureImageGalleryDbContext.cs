using AzureImagesGallery.Data.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureImagesGallery.Data.Persistance.Context
{
    public class AzureImageGalleryDbContext : DbContext
    {
        public AzureImageGalleryDbContext(DbContextOptions<AzureImageGalleryDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<GalleryImage> GallerlyImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*
             * Configuring Gallery Image Entity through fluent API as
             * It has higher priority then DataAnnotation Attributes
             */
            modelBuilder.Entity<GalleryImage>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
                entity.Property(x => x.Title).IsRequired().HasMaxLength(35);
            });

            /*
             * Configuring Image Tag Entity
             */
            modelBuilder.Entity<ImageTag>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            });
        }
    }
}
