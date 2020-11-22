using DataAcces.DTO;
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

        public Cliente (string _nombre, string _apellido, string _documento, string _telefono)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.documento = _documento;
            this.telefono = _telefono;
        }


        private string nombre;
        private string apellido;
        private string documento;
        private string telefono;
        private bool frecuente;

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public string GetDocumento()
        {
            return this.documento;
        }

        public string GetTelefono()
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

        public void SetDocumento(string _documento)
        {
            this.documento = _documento;
        }

        public void SetTelefono(string _telefono)
        {
            this.telefono = _telefono;
        }

        public void SetFrecuente(bool _frecuente)
        {
            this.frecuente = _frecuente;
        }

        
    }
}
