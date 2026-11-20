using Domain.Entities;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppUser = Infrastructure.Identity.User;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ExporterProfile> ExporterProfiles { get; set; }
        public DbSet<BuyerProfile> BuyerProfiles { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<BuyRequest> BuyRequests { get; set; }
        public DbSet<SellOffer> SellOffers { get; set; }
        public DbSet<RequiredDocument> RequiredDocuments { get; set; }
        public DbSet<ListingDocument> ListingDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // keeps Identity's own table configs

            builder.Entity<AppUser>()
                .HasOne(u => u.ExporterProfile)
                .WithOne(e => e.User)
                .HasForeignKey<ExporterProfile>(e => e.UserId);

            builder.Entity<AppUser>()
                .HasOne(u => u.BuyerProfile)
                .WithOne(b => b.User)
                .HasForeignKey<BuyerProfile>(b => b.UserId);

            builder.Entity<SellOffer>()
                .HasMany(s => s.AvailableDocuments)
                .WithOne(d => d.SellOffer)
                .HasForeignKey(d => d.SellOfferId);

            builder.Entity<BuyRequest>()
                .HasMany(b => b.RequiredDocuments)
                .WithOne(d => d.BuyRequest)
                .HasForeignKey(d => d.BuyRequestId);
        }
    }
}