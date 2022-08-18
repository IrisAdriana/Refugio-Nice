using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;

namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoDocumentoController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet(Name = "ObtenerListaTiposDocumento")]
        public List<TipoDocumento> ObtenerListaTiposDocumento()
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            return bd.ListaTipoDocumento();

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
    }
}
