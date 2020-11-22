using DataAcces;
using DataAcces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class ReservaHelper
    {
        public List<string> AgregarReserva(DtoReserva dto)
        {
            //Validaciones

            List<string> colErrores = validarDtoReserva(dto);
            if (colErrores.Count() == 0)
            {
                Cliente _cliente = Listas.GetClienteByDocument(dto.documento);
                Mesa _mesa = Listas.GetMesaByNumber(dto.mesa);
                DateTime _fecha = DateTime.Parse(dto.fechaHoraDeReserva);
                short _cantDeComensales = short.Parse(dto.cantidadComensales);
                int _numero = NumeroAI();
                Reserva nuevaReserva = new Reserva(_numero, _cantDeComensales, _fecha,  _cliente , _mesa);
                Listas.AgregarReserva(nuevaReserva);
            }

            return colErrores;

        }

        public List<string> validarDtoReserva(DtoReserva dto)
        {
            List<string> colMsgError = new List<string>();

            if (string.IsNullOrEmpty(dto.documento))
            {
                colMsgError.Add("Debe seleccionar un documento de cliente");
            }
            else
            {
                Cliente _cliente = Listas.GetClienteByDocument(dto.documento);

                if (_cliente == null)
                {
                    colMsgError.Add("El cliente no esta registrado con ese documento. Debe registrarlo primero");
                }
            }


            if (string.IsNullOrEmpty(dto.mesa))
            {
                colMsgError.Add("Debe seleccionar una mesa");
            }
            else
            {
                if (short.Parse(dto.mesa) > Listas.colMesas.Count())
                {
                    colMsgError.Add("Esa mesa no existe. Seleccione una mesa con un numero menor a " + Listas.colMesas.Count());
                }
            }

            

            if (string.IsNullOrEmpty(dto.cantidadComensales))
            {
                colMsgError.Add("Debe seleccionar una cantidad de comensales");
            }
            else
            {
                if (short.Parse(dto.cantidadComensales) <= 0)
                {
                    colMsgError.Add("La cantidad de comensales debe ser un número mayor a cero y menor a ");
                }
            }

            if (string.IsNullOrEmpty(dto.fechaHoraDeReserva))
            {
                colMsgError.Add("La fecha es requerida");
            }


            return colMsgError;
        }

        public List<DtoReserva> ListarReservas()
        {
            List<DtoReserva> colDtoReservas = new List<DtoReserva>();

            List<Reserva> colReservas = Listas.ListarReservas();

            if(colReservas != null)
            {
                foreach (Reserva item in colReservas)
                {
                    DtoReserva dto = new DtoReserva();
                    dto.numero = item.GetNumero().ToString();
                    dto.mesa = item.GetMesa().GetNroDeMesa().ToString();
                    dto.documento = item.GetCliente().GetDocumento().ToString();
                    dto.nombre = item.GetCliente().GetNombre();
                    dto.apellido = item.GetCliente().GetApellido();
                    dto.cantidadComensales = item.GetCantidadComensales().ToString();
                    string dia = (item.GetFechaHoraReserva().Day).ToString();
                    string anio = (item.GetFechaHoraReserva().Year).ToString();
                    string mes = (item.GetFechaHoraReserva().Month).ToString();
                    string hora = (item.GetFechaHoraReserva().Hour).ToString();
                    string minutos = (item.GetFechaHoraReserva().Minute).ToString();
                    dto.fechaHoraDeReserva = dia + "/" + mes + "/" + anio + " - " + hora + ":" + minutos ;

                    colDtoReservas.Add(dto);
                }
            }

            return colDtoReservas;
        }

        public Cliente ConvertToCliente(DtoCliente _cliente)//No se si es necesaria
        {
            Cliente cliente = new Cliente();
            cliente.SetNombre(_cliente.nombre);
            cliente.SetApellido(_cliente.apellido);
            cliente.SetDocumento(_cliente.documento);
            cliente.SetTelefono(_cliente.telefono);

            return cliente;
        }

        public int NumeroAI()
        {
            int numero;
            if(Listas.colReservas == null)
            {
                numero = 0;
            }
            else
            {
                
                numero = Listas.numeroReserva + 1;
                Listas.numeroReserva = numero;
            }
            return numero;
        }
        

        
    }
}
