using AutoMapper;
using CanadianResidencyStatus.Data;
using CanadianResidencyStatus.Models.Country;
using CanadianResidencyStatus.Models.Job;
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

            CreateMap<Job, CreateJobDto>().ReverseMap();
            CreateMap<Job, GetJobDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<Job, UpdateJobDto>().ReverseMap();


            CreateMap<Resident, ResidentDto>().ReverseMap();
        }

    }
}
