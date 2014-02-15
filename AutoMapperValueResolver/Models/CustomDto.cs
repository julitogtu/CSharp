using AutoMapper;
using AutoMapperValueResolver.Resolver;

namespace AutoMapperValueResolver.Models
{
    public class CustomDto : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "CustomDto";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientViewModel>()
                .ForMember(d => d.Name, o => o.ResolveUsing<FullNameResolver>())
                .ForMember(d => d.Email, o => o.MapFrom(c => c.Email));
        }
    }
}