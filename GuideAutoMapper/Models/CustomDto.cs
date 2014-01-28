using AutoMapper;

namespace GuideAutoMapper.Models
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
                .ForMember(d => d.Name, o => o.MapFrom(c => c.Name))
                .ForMember(d => d.LastName, o => o.NullSubstitute("-"))
                .ForMember(d => d.Email, o => o.MapFrom(c => c.Email));
        }
    }
}