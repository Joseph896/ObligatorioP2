using BussinesLogic;
using DataAcces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WsAplicacion.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpPost]
        [ActionName("RegistrarCliente")]
        public List<string> RegistrarCliente([FromBody] DtoCliente nuevoCliente)
        {
            ClienteHelper cliHelper = new ClienteHelper();
            List<string> colErrores = cliHelper.RegistrarCliente(nuevoCliente);
            return colErrores;
        }

        [HttpGet]
        [ActionName("BuscarCliente")]
        public DtoCliente GetPersonasById(string documento)
        {
            ClienteHelper cliHelper = new ClienteHelper();
            DtoCliente clienteBusqueda = cliHelper.BuscarCliente(documento);
            return clienteBusqueda;
        }
    }
}