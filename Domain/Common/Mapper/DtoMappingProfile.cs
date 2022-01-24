namespace Web.Global.Mapper
{
    using AutoMapper;
    using SSRNMFSSN.Data.Models;
    using SSRNMFSSN.Data.Models.DTO;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DtoMappingProfile : Profile
    {
        private static IEnumerable<Type> GetTypesWithAttributes()
        {
            return from a in AppDomain.CurrentDomain.GetAssemblies()
                   from t in a.GetTypes()
                   where t.IsDefined(typeof(AutoMapperDestination), false)
                   select t;
        }

        public DtoMappingProfile() : base()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
