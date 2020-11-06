using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class Mozo
    {

        public Mozo()
        {

        }

        private string nombre;
        private string apellido;
        private int numero;

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetNombre(string _nombre)
        {
            this.nombre = _nombre;
        }

        public void SetApellido(string _apellido)
        {
            this.apellido = _apellido;
        }

        public void SetNumero(int _numero)
        {
            this.numero = _numero;
        }
    }
}
