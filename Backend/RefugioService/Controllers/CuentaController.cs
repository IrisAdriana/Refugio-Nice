using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;
namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuentaController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet(Name = "Cuenta")]
<<<<<<< HEAD
        //public Cuenta VerificarCuenta(string cuenta,string pwd)
        public bool VerificarCuenta(string cuenta, string pwd)
=======
        public bool VerificarCuenta(string cuenta,string pwd)
>>>>>>> be9ac0a55d3277aa89cc178acc65387df8c324e8
        {
            //try
            //{
                clsBaseDatos bd = new clsBaseDatos();
                return bd.VerificarCuenta(cuenta, pwd);            

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
    }
}
