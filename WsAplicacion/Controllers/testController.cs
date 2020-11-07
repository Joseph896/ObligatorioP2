using DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WsAplicacion.Controllers
{
    public class testController: ApiController
    {
        [HttpPost]
        [ActionName("agregarTest")]
        public void agregarStringAlistaTest(string test)
        {
            Listas.colTest.Add(test);
        }

        [HttpGet]
        [ActionName("retornar")]
        public string retornar()
        {

            return "Exito";
        }
        [HttpGet]
        [ActionName("sumar")]
        public int suma(int a, int b)
        {
            return a+b;
        }
    }
}