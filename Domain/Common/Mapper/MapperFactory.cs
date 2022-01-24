using AutoMapper;
using Web.Global.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapper
{
    public class MapperFactory
    {
        public static IMapper Mapper { get; set; }

        public static void Init()
        {
            var config = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile<DtoMappingProfile>();
            });
            Mapper = config.CreateMapper();
        }
    }
}
