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
}
