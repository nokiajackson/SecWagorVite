using AutoMapper;
using SecWagoreVite.Server.Helpers;
using SecWagoreVite.Server.Controllers.Service;
using SecWagoreVite.Server.Models;
using SecWagoreVite.Server.Service;
using SecWagore;
using SecWagoreVite.Server.Controllers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Mapping from EntryLogVM to EntryLog
        CreateMap<EntryLogVM, EntryLog>()
            .ForMember(dest => dest.Purpose, opt => opt.MapFrom(src => (int)src.Purpose));

        // Mapping from EntryLog to EntryLogVM
        CreateMap<EntryLog, EntryLogVM>()
            .ForMember(dest => dest.Purpose, opt => opt.MapFrom(src => (Purpose)src.Purpose));

    }
}