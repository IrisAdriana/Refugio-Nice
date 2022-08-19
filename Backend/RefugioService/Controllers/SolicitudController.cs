using Microsoft.AspNetCore.Mvc;
using RefugioService.Objetos;
using RefugioService.Utiles;
namespace RefugioService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolicitudController : ControllerBase
    {
        [HttpPost(Name = "CrearNuevaSolicitud")]
        public void CrearNuevaSolicitud(Solicitud solicitud)
        {
            //try
            //{
            clsBaseDatos bd = new clsBaseDatos();
            bd.NuevoSolicitud(solicitud);

            //}
            //catch (Exception ex)
            //{

            //    //throw;
            //    //return StatusCode(StatusCodes.Status200OK, "ok");
            //}
        }
    }
}
