using BussinesLogic;
using DataAcces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WsAplicacion.Controllers
{
    public class ReservaController : ApiController 
    {
        [HttpPost]
        [ActionName("AgregarReserva")]
        public List<string> AgregarReserva([FromBody]DtoReserva nuevaReserva)
        {
            ReservaHelper resHelper = new ReservaHelper();
            List<string> colErrores = resHelper.AgregarReserva(nuevaReserva);
            return colErrores;
        }

        [HttpGet]
        [ActionName("ListarReservas")]
        public List<DtoReserva> ListarReservas()
        {
            ReservaHelper resHelper = new ReservaHelper();
            List<DtoReserva> colReservas = resHelper.ListarReservas();
            return colReservas;
        }
    }
}