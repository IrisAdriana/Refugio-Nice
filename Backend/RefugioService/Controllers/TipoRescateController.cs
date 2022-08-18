using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;
namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoRescateController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet(Name = "ObtenerListaTipoRescate")]
        public List<TiposRescate> ObtenerListaTipoMensaje()
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            return bd.ListaTiposRescates();

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
    }
}
