using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Project.BLL.AutoMapper
{
    public class AutoMapperInit
    {
        public static void Init()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<ProjectAutoMapperProfile>();
            });
        }
    }

    public class ProjectAutoMapperProfile : Profile
    {
        public ProjectAutoMapperProfile()
        {
            CreateMap<DAL.Model.Location, BDO.Location>();
        }
    }
}
