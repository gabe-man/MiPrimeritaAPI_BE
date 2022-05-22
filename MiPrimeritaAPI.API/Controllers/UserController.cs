using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.CORE.DTO;

namespace MiPrimeritaAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserBL userBL { get; set; }

        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult Login(LoginDTO login)
        {
            if (userBL.CheckUserLogin(login))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Register")]
        public ActionResult Register(UserDTO user)
        {
            if (userBL.CheckUserRegister(user))
            {
                return BadRequest();
            }
            else
            {
                userBL.Register(user);
                return Ok();
            }
        }
    }
}
