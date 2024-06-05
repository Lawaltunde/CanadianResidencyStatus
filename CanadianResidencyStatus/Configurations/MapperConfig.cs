using AutoMapper;
using CanadianResidencyStatus.Data;
using CanadianResidencyStatus.Models.Country;

namespace CanadianResidencyStatus.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
        }

    }
}
