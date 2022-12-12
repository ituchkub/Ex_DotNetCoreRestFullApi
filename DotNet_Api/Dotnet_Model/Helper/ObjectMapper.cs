using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db = Dotnet_DataAccess.Models.DB;
using Dotnet_Model;


namespace Dotnet_Model.Helper
{
    public static class ObjectMapper
    {
       
       
   
        public static EmployeeModel ToViewModel(this Db.MasEmployee item)
        {
            return new EmployeeModel
            {
                Email = item.Email,
                FirstName = item.Fname,
                LastName = item.Surname
            };
        }
        public static List<EmployeeModel> ToViewModel(this List<Db.MasEmployee> items)
        {
            return items.Select(i => i.ToViewModel()).ToList();
        }
       
    }
}
