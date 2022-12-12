using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Model
{
    public class EmployeeModel
    {
        public int LDEP { get; set; }
        public string? EmpId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ChgPassword { get; set; }
        public int Active { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? RoleID { get; set; }
        public string? StatusId { get; set; }
        public string? ExpireDate { get; set; }
        public string? LastEditPWD { get; set; }

    }

}
