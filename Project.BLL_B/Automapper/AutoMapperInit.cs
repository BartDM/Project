using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Project.BLL.AutoMapper
{
    public class AutoMapperInit
    {
        public static IMapper Init()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProjectAutoMapperProfile>();
            });
            return config.CreateMapper();
        }
    }

    public class ProjectAutoMapperProfile : Profile
    {
        public ProjectAutoMapperProfile()
        {
            CreateMap<DAL.Model.Vendor, BDO.Vendor>();
            CreateMap<DAL.Model.Location, BDO.Location>()
                .ForMember(s => s.LocationId, opt => opt.MapFrom(l => l.LocId));

            CreateMap<DAL.Model.ProductUser, BDO.ProductUser>();
            CreateMap<DAL.Model.ProgramUser, BDO.ProgramUser>();
            CreateMap<DAL.Model.User, BDO.User>();

            CreateMap<DAL.Model.Product, BDO.Product>();
            CreateMap<DAL.Model.OperatingSystem, BDO.OperatingSystem>();
            CreateMap<DAL.Model.Software, BDO.Software>();

            CreateMap<DAL.Model.Computer, BDO.Computer>();
            CreateMap<DAL.Model.VM, BDO.VM>();
            CreateMap<DAL.Model.PM, BDO.PM>();

            CreateMap<DAL.Model.Vlan, BDO.Vlan>();           
            CreateMap<DAL.Model.NetworkInterface, BDO.NetworkInterface>()
               .ForMember(s => s.NetworkInterfaceId, opt => opt.MapFrom(l => l.NwiId));
            
        }
    }
}
