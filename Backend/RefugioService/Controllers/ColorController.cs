using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;

namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase//Controller
    {
        //public IActionResult Index()
        //{
        //    //return View();
        //}
        [HttpGet(Name = "Color")]
        public List<clsColor> ObtenerListaColores()
        {
            //try
            //{
                clsBaseDatos bd = new clsBaseDatos();
                return bd.ListaColores();

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }

    }
}
