using AutoMapper;
using DataLayer;
using Models;


namespace BuisnessLayer.AutoMapperProfiles
{
    public class FeeDetailsProfile : Profile
    {
        public FeeDetailsProfile()
        {
            CreateMap<uspDashboard_Result, FeeDetails>();
        }
    }
}
