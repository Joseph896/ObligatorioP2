using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class Cliente
    {
        public Cliente()
        {

        }


        private string nombre;
        private string apellido;
        private char documento;
        private char telefono;
        private bool frecuente;

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public char GetDocumento()
        {
            return this.documento;
        }

        public char GetTelefono()
        {
            return this.telefono;
        }

        public bool GetFrecuente()
        {
            return this.frecuente;
        }

        public void SetNombre(string _nombre)
        {
            this.nombre = _nombre;
        }

        public void SetApellido(string _apellido)
        {
            this.apellido = _apellido;
        }

        public void SetDocumento(char _documento)
        {
            this.documento = _documento;
        }

        public void SetTelefono(char _telefono)
        {
            this.telefono = _telefono;
        }

        public void SetFrecuente(bool _frecuente)
        {
            this.frecuente = _frecuente;
        }
    }
}
