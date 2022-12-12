using System;
using System.Collections.Generic;
using System.Linq;
using Dotnet_Model;
using Dotnet_DataAccess;
using Db = Dotnet_DataAccess.Models.DB;
using Dotnet_Model.Helper;

namespace Dotnet_Service
{
    public interface IMasterServices
    {
        List<EmployeeModel> GetIncotermLocationByIncoterm(int IncotermLId);
    }
    public class MasterServices : IMasterServices
    {
        private readonly IUnitOfWork uow;
        private readonly DateTime _dateTime;
        public MasterServices(IUnitOfWork unitOfWork, DateTime dateTime)
        {
            this.uow = unitOfWork;
            this._dateTime = dateTime;
        }

        public List<EmployeeModel> GetIncotermLocationByIncoterm(int IncotermLId)
        {
            var data = this.uow.MasEmployeeRepository.GetAll().ToList();
            return data.ToViewModel();
        }
    }
}
