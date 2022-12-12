using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        

        [HttpPost]
        [Route("Header/GetHeaderByID")]
        public IActionResult GetItemsByItemGroupID(string OEHeadID)
        {
            try
            {
                var result = this._services.GetHeaderByID(OEHeadID);
                return JsonResult(new ResponseMessage<TranOefromHeadRespone>()
                {
                    Status = true,
                    StatusId = 0,
                    ErrorMessage = "",
                    Token = this.CurrentUser.Token,
                    SessionEmpID = this.CurrentUser.Id,
                    body = result,
                });
            }
            catch (Exception ex)
            {
                return JsonResult(new ResponseMessage<TranOefromHeadRespone>()
                {
                    Status = false,
                    StatusId = 1,
                    ErrorMessage = ex.Message,
                    Token = this.CurrentUser.Token,
                    SessionEmpID = this.CurrentUser.Id,
                });
            }
        }
    }
}