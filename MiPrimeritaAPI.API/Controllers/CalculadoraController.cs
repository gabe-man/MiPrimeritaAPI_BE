using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiPrimeritaAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet]
        [Route("Suma")]
        public int Suma(int n1, int n2)
        {
           return n1 + n2;
        }

        [HttpGet]
        [Route("Division")]
        public int Division(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
