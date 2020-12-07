
using AutoMapper;
using CloudLibrary.Core.Services.Model;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Core.Entities;

namespace CloudLibrary.Frontend
{
    public class AutoMapperProfile : Profile
    {
        
        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize(a =>
            {
                a.AddProfile<AutoMapperProfile>();
            });
        }
        public AutoMapperProfile()
        {
            CreateMap<HardwareProfile, HardwareProfileModel>().ReverseMap();
            CreateMap<StorageProfile, StorageProfileModel>().ReverseMap();
            CreateMap<NetworkProfile, NetworkProfileModel>().ReverseMap();
            CreateMap<VirtualMachine, CreateVmResourceRequest>().ReverseMap();
        }
    }
}