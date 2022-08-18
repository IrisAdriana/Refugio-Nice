using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;

namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MascotaController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet(Name = "ObtenerListaMascotas")]
        public List<clsMascota> ObtenerListaMascotas()
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            return bd.ListaMascotas();

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
        [HttpPost(Name = "CrearNuevaMascota")]
        public void CrearNuevaMascota(clsMascota mascota)
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            bd.NuevaMascota(mascota);

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
    }
}
