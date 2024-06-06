using AutoMapper;
using CanadianResidencyStatus.Data;
using CanadianResidencyStatus.Models.Country;
using CanadianResidencyStatus.Models.Resident;

namespace CanadianResidencyStatus.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();


            CreateMap<Resident, ResidentDto>().ReverseMap();
        }

    }
}
