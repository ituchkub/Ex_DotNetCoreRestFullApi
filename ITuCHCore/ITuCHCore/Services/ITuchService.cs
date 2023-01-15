using ITuCHCore.Models.DB;
using Microsoft.AspNetCore.Mvc;

namespace ITuCHCore.Service
{
    public interface ITuchService
    {
        List<MasEmployee> GetAll();
        MasEmployee Get(int Id);
        MasEmployee AddUser(MasEmployee UserDetail);
        MasEmployee UpdateUser(MasEmployee UserDetail);
        MasEmployee DeleteHeaderFromHeaderIDAsync(int id);
    }

    public class TuchService : ITuchService
    {
        private readonly UserDataContext _context;

        public TuchService(UserDataContext Context)
        {
            _context = Context;
        }

        public MasEmployee DeleteHeaderFromHeaderIDAsync(int Id)
        {
            var Employee = _context.MasEmployees.Find(Id);
            if (Employee == null)
            {
                return null;
            }
            _context.MasEmployees.Remove(Employee);
            _context.SaveChangesAsync();
            return Employee;
        }
        public List<MasEmployee> GetAll()
        {
            var EmployeeList = _context.MasEmployees.ToList();
            return EmployeeList;
        }
        public MasEmployee Get(int Id)
        {
            var Employee = _context.MasEmployees.Find(Id);
            if (Employee == null)
            {
                return null;
            }
            return Employee;
        }
        public MasEmployee AddUser(MasEmployee UserDetail)
        {
            _context.MasEmployees.Add(UserDetail);
            _context.SaveChanges();
            return UserDetail;
        }
        public MasEmployee UpdateUser(MasEmployee UserDetail)
        {
            var Employee = _context.MasEmployees.Find(UserDetail.EmpId);
            if (Employee == null)
            {
                return null;
            }
            Employee.Name = UserDetail.Name;
            Employee.Surname = UserDetail.Surname;
            Employee.Telephone = UserDetail.Telephone;
            Employee.Email = UserDetail.Email;
            _context.SaveChanges();
            return Employee;

        }
    }
}
