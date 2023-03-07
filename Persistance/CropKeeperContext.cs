using CropKeeperApi.Persistance.Entities;
using Microsoft.EntityFrameworkCore;

namespace CropKeeperApi.Persistance;

public partial class CropKeeperContext : DbContext
{
    public CropKeeperContext(DbContextOptions<CropKeeperContext> options)
        : base(options)
    { }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<GardenPlot> GardenPlots { get; set; }

    public virtual DbSet<GardenPlotCrop> GardenPlotCrops { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Crop> Crops { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasQueryFilter(entity => entity.DateDeleted == null);
        modelBuilder.Entity<Crop>().HasQueryFilter(entity => entity.DateDeleted == null);
        modelBuilder.Entity<GardenPlot>().HasQueryFilter(entity => entity.DateDeleted == null);
        modelBuilder.Entity<GardenPlotCrop>().HasQueryFilter(entity => entity.DateDeleted == null);
        modelBuilder.Entity<Notification>().HasQueryFilter(entity => entity.DateDeleted == null);
    }
}
