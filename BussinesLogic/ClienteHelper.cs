using DataAcces;
using DataAcces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class ClienteHelper
    {
        

        public List<string> RegistrarCliente(DtoCliente dto)
        {
            List<string> colErrores = validarDtoCliente(dto);
            if (colErrores.Count() == 0)
            {
                
                Cliente nuevoCliente = new Cliente(dto.nombre, dto.apellido, dto.documento, dto.telefono);
                Listas.RegistrarCliente(nuevoCliente);
            }

            return colErrores;
        }

        public List<string> validarDtoCliente(DtoCliente dto)
        {
            List<string> colMsgError = new List<string>();

            if (string.IsNullOrEmpty(dto.nombre))
            {
                colMsgError.Add("El nombre es requerido");
            }

            if (string.IsNullOrEmpty(dto.apellido))
            {
                colMsgError.Add("El apellido es requerido");
            }

            if (string.IsNullOrEmpty(dto.documento))
            {
                colMsgError.Add("Debe seleccionar una documento");
            }

            if (string.IsNullOrEmpty(dto.telefono))
            {
                colMsgError.Add("Debe ingresar un telefono");
            }


            return colMsgError;
        }

        public DtoCliente BuscarCliente(string documento)
        {
            DtoCliente dto = new DtoCliente();
            Cliente clienteBusqueda = Listas.GetClienteByDocument(documento);
            if (clienteBusqueda != null)
            {
                dto.nombre = clienteBusqueda.GetNombre();
                dto.apellido = clienteBusqueda.GetApellido();
                dto.telefono = clienteBusqueda.GetTelefono();
            }

            return dto;
        }
    }
}
