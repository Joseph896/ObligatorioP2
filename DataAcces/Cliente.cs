using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class Cliente
    {

        private string nombre;
        private string apellido;
        private char documento;
        private char telefono;
        private bool frecuente;

        public string GetNombre()
        {
            return this.nombre;
        }

    }
}
