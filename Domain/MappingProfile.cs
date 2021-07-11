using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TeeBox.Domain.DTO;

namespace TeeBox.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hole, HoleDTO>();
            CreateMap<Tee, HoleTeeDTO>();
            CreateMap<TeeColor, HoleTeeDTO>()
                .ForMember(d => d.Color, opt => opt.MapFrom(s => s.Color));

            CreateMap<IEnumerable<HoleTeeDTO>, HoleDTO>()
                .ForMember(d => d.HoleTees, opt => opt.MapFrom(s => s));


            CreateMap<Course, CourseDTO>();


        }
    }

    public static class MappingProfileExtensions
    {
        public static TDestination Map<TSource1, TSource2, TDestination>(
        this IMapper mapper, TSource1 source1, TSource2 source2)
        {
            var destination = mapper.Map<TSource1, TDestination>(source1);
            return mapper.Map(source2, destination);
        }

        public static TResult MergeInto<TResult>(this IMapper mapper, object item1, object item2)
        {
            return mapper.Map(item2, mapper.Map<TResult>(item1));
        }

        public static TResult MergeInto<TResult>(this IMapper mapper, params object[] objects)
        {
            var res = mapper.Map<TResult>(objects.First());
            return objects.Skip(1).Aggregate(res, (r, obj) => mapper.Map(obj, r));
        }
    }
}
