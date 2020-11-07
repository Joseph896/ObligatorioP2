using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WsAplicacion.Controllers
{
    public class PruebaController:ApiController
    {
        [HttpGet]
        [ActionName("sumar")]
        public int sumarAyB(int A, int B)
        {
            return A + B;
        }
    }
}