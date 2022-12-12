using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DotNet_DataAccess.Models.Context;
using DotNet_DataAccess.Repository;
using Db = DotNet_DataAccess.Models.DB;

namespace DotNet_DataAccess
{
    public interface IMasEmployeeRepository : IRepository<Db.MasEmployee>
    {
        int GetEmployeeRole(int empId); 
        bool CheckCreateRole(int empId);
    }
    public class MasEmployeeRepository : GenericRepository<Db.MasEmployee>, IMasEmployeeRepository
    {
        public MasEmployeeRepository(DotnetContext context) : base(context)
        {

        }

        public int GetEmployeeRole(int empId)
        {
            var user = base._context.MasEmployees.Where(i => i.EmpId == empId).First();
            return user.RoleId.Value;
        }

        public bool CheckCreateRole(int empId)
        {
            //var user = base._context.MasEmployeeGroupRoles.Where(i => i.EmpId == empId &&i.RoleId == 1);
            //return user.Count()>0;

            return false;
        }
    }
}
