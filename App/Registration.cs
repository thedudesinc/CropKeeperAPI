using CropKeeperApi.Domain.Abstractions.Repositories;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Profiles;
using CropKeeperApi.Domain.Services;
using CropKeeperApi.Persistance;
using CropKeeperApi.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CropKeeperApi.App;

public static class Registration
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CropKeeperContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CropKeeperDbContext")));

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IGardenPlotRepository, GardenPlotRepository>();
        services.AddTransient<IGardenPlotCropRepository, GardenPlotCropRepository>();
        services.AddTransient<INotificationRepository, NotificationRepository>();
        services.AddTransient<ICropRepository, CropRepository>();
        services.AddTransient<IUserService, UserService>();

        services.AddAutoMapper(typeof(CropKeeperProfile));
    }
}

