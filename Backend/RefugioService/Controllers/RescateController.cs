using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;
namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RescateController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet(Name = "ObtenerListaRescates")]
        public List<Rescate> ObtenerListaRescates()
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            return bd.ListaRescates();

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
        [HttpPost(Name = "CrearNuevoRescate")]
        public void CrearNuevaMascota(Rescate rescate)
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            bd.NuevoRescate(rescate);

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
    }
}
