using AutoMapper;
using BuisnessLayer.AutoMapperSettings;
using BuisnessLayer.Interface;
using DataLayer;
using DataLayer.Interface;
using Models;
using System.Collections.Generic;
using System.Linq;


namespace BuisnessLayer.Implementation
{
    public class DashBoardFeeServices : IDashBoardFeeServices
    {
        public IRepository<FeeDetails> _repository;

        public DashBoardFeeServices(IRepository<FeeDetails> repository)
        {
            _repository = repository;
        }
        public List<FeeDetails> GetfeeDetails()
        {
            var FeeDetails = _repository.ExecWithStoreProcedure<uspDashboard_Result>("exec uspDashboard").ToList();
            List<FeeDetails> lstFeeDetails = AutoMapperConfig.mapper.Map<List<uspDashboard_Result>, List<FeeDetails>>(FeeDetails);
            return lstFeeDetails;
        }
    }
}
