using ITuCHCore.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITuCHCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ITuchController : Controller
    {

   
        private readonly UserDataContext _context;

        public ITuchController(UserDataContext Context) {
            _context = Context;
        }
        [HttpGet]
        public async Task<ActionResult<List<MasEmployee>>> Get()
        {


            return Ok(await _context.MasEmployees.ToListAsync());
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<MasEmployee>> Get(int Id)
        {
            var Employee = await _context.MasEmployees.FindAsync(Id);
            if (Employee == null) 
            {
                return BadRequest("Data Not Fould !!");
            }
            return Ok(Employee);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<MasEmployee>> Delete(int Id)
        {
            var Employee = await _context.MasEmployees.FindAsync(Id);
            if (Employee == null)
            {
                return BadRequest("Data Not Fould !!");
            }
            _context.MasEmployees.Remove(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);
        }

        [HttpPut]
        public async Task<ActionResult<MasEmployee>> UpdateUser(MasEmployee UserDetail)
        {
            var Employee = await _context.MasEmployees.FindAsync(UserDetail.EmpId);
            if (Employee == null)
            {
                return BadRequest("Data Not Fould !!");
            }

            Employee.Name= UserDetail.Name;
            Employee.Surname = UserDetail.Surname;
            Employee.Telephone = UserDetail.Telephone;
            Employee.Email = UserDetail.Email;
            await _context.SaveChangesAsync();
            return Ok(Employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<MasEmployee>>> AddUser(MasEmployee User)
        {

            _context.MasEmployees.Add(User);
            await _context.SaveChangesAsync();
            return Ok(User);
        }
    }
}
