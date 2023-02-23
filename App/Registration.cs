using CropKeeperApi.Persistance;
using Microsoft.EntityFrameworkCore;

namespace CropKeeperApi.App;

public static class Registration
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CropKeeperContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CropKeeperDbContext")));
    }
}

