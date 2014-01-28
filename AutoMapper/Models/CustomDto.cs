
namespace AutoMapper.Models
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
            Mapper.CreateMap<Client, ClientViewModel>();
        }
    }
}