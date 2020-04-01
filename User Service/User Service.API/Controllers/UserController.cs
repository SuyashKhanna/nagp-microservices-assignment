using Microsoft.AspNetCore.Mvc;

namespace User_Service.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{controller}/{id}")]
        public JsonResult Get(int id){
            User user = new User();
            user.Name = "Suyash Khanna";
            user.Email = "suyash.khanna@nagarro.com";
            return new JsonResult(user);
        }
    }
}