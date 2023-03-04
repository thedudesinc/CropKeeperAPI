using AutoMapper;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using CropKeeperApi.Persistance.Entities;

namespace CropKeeperApi.Domain.Profiles;

public class CropKeeperProfile : Profile
{
    public CropKeeperProfile()
    {
        CreateMap<UserInput, User>();
        CreateMap<User, UserOutput>();

        CreateMap<CropInput, Crop>();
        CreateMap<Crop, CropOutput>();

        CreateMap<NotificationInput, Notification>();
        CreateMap<Notification, NotificationOutput>();

        CreateMap<GardenPlotInput, GardenPlot>();
        CreateMap<GardenPlot, GardenPlotOutput>();

        CreateMap<GardenPlotCropInput, GardenPlotCrop>();
        CreateMap<GardenPlotCrop, GardenPlotCropOutput>();
        // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
    }
}
