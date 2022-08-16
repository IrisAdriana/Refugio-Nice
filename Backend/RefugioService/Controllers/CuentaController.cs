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
        public Cuenta VerificarCuenta(string cuenta,string pwd)
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
