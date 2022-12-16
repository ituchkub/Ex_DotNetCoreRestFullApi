using ITuCHCore.Models.DB;
using ITuCHCore.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITuCHCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ITuchController : Controller
    {



        private readonly ITuchService _service;

        public ITuchController(UserDataContext Context, ITuchService Service)
        {
      
            _service = Service;
        }
        [HttpGet]
        public ActionResult<List<MasEmployee>> Get()
        {
            var Result = this._service.GetAll();
            return Ok();
        }
        [HttpGet("{Id}")]
        public ActionResult<MasEmployee> Get(int Id)
        {
            var Result = this._service.Get(Id);
            if (Result == null)
            {
                return BadRequest("Data Not Fould !!");
            }
            return Ok(Result);
        }

        [HttpDelete("{Id}")]
        public ActionResult<MasEmployee> Delete(int Id)
        {
            var Result = this._service.DeleteHeaderFromHeaderIDAsync(Id);
            if (Result == null)
            {
                return BadRequest("Data Not Fould !!");
            }
            return Ok(Result);
        }

        [HttpPut]
        public ActionResult<MasEmployee> UpdateUser(MasEmployee UserDetail)
        {
            var Employee = this._service.UpdateUser(UserDetail);
            if (Employee == null)
            {
                return BadRequest("Data Not Fould !!");
            }
            return Ok(Employee);
        }

        [HttpPost]
        public  ActionResult<List<MasEmployee>> AddUser(MasEmployee User)
        {
            var Employee = this._service.AddUser(User);
            return Ok(User);
        }
    }
}
