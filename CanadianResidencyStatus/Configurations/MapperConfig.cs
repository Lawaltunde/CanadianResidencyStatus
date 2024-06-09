using AutoMapper;
using CanadianResidencyStatus.Data;
using CanadianResidencyStatus.Models.Country;
using CanadianResidencyStatus.Models.Job;
using CanadianResidencyStatus.Models.Resident;
using CanadianResidencyStatus.Models.StatusInCanada;

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

            CreateMap<StatusInCanada, CreateStatusInCanadaDto>().ReverseMap();
            CreateMap<StatusInCanada,  GetStatusInCanadaDto>().ReverseMap();
            CreateMap<StatusInCanada, StatusInCanadaDto>().ReverseMap();
            CreateMap<StatusInCanada, UpdateStatusInCanadaDto>().ReverseMap();

            CreateMap<Resident, CreateResidentDto>().ReverseMap();
            CreateMap<Resident, GetResidentDto>().ReverseMap();
            CreateMap<Resident, ResidentDto>().ReverseMap();
            CreateMap<Resident, UpdateResidentDto>().ReverseMap();
        }

    }
}
