using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class Listas
    {
        public static List<Opcion> colOpcionesDelMenu=new List<Opcion>();
        public static List<Cliente> colClientes = new List<Cliente>();
        public static List<Mozo> colMozos = new List<Mozo>();
        public static List<Mesa> colMesas = CrearMesas();
        public static List<Cuenta> colCuentas = new List<Cuenta>();
        public static List<Reserva> colReservas = new List<Reserva>();
        public static int numeroReserva;

        public static void AgregarReserva(Reserva nuevaReserva)
        {
            if (colReservas == null)
            {
                colReservas = new List<Reserva>();
            }

            colReservas.Add(nuevaReserva);
        }

        public static List<Reserva> ListarReservas()
        {
            return colReservas;
        }

        public static Cliente GetClienteByDocument(string documento)
        {
          
            Cliente cliente = null;
            foreach (Cliente item in Listas.colClientes)
            {
                if (item.GetDocumento() == documento)
                {
                    cliente = item;
                }
            }
            return cliente;
        }

        public static Mesa GetMesaByNumber(string _nroMesa )
        {
            short nroMesa = short.Parse(_nroMesa);
            Mesa mesa = null;
            foreach (Mesa item in Listas.colMesas)
            {
                if (item.GetNroDeMesa() == nroMesa)
                {
                    mesa = item;
                }
            }
            return mesa;
        }

        public static void RegistrarCliente(Cliente nuevoCliente)
        {
            if (colClientes == null)
            {
                colClientes = new List<Cliente>();
            }

            colClientes.Add(nuevoCliente);
        }

        public static List<Mesa> CrearMesas()
        {
            List<Mesa> _colMesas = new List<Mesa>();
            short contador = 0;
            for (int i = 0; i < 40; i++)
            {
                Mesa mesa = new Mesa();
                contador += 1;
                mesa.SetNroDeMesa(contador);
                if (contador > 0 && contador <= 10)
                {
                    mesa.SetSeccion(1);
                }
                else if (contador > 10 && contador <= 20)
                {
                        mesa.SetSeccion(2);
                }
                else if (contador > 20 && contador <= 30)
                {
                        mesa.SetSeccion(3);
                }
                else if (contador > 30 && contador <= 40)
                {
                        mesa.SetSeccion(4);
                }
                mesa.SetCantDeSillas(4);

                _colMesas.Add(mesa);
            }

            return _colMesas;
        }

        public static void AgregarMesa(short _cantSillas)
        {
            short _nroDeMesa = short.Parse(colMesas.Count().ToString() + 1);
            Mesa mesa = new Mesa();
            if (_nroDeMesa > 0 && _nroDeMesa <= 10)
            {
                mesa.SetSeccion(1);
            }
            else if (_nroDeMesa > 10 && _nroDeMesa <= 20)
            {
                mesa.SetSeccion(2);
            }
            else if (_nroDeMesa > 20 && _nroDeMesa <= 30)
            {
                mesa.SetSeccion(3);
            }
            else if (_nroDeMesa > 30 && _nroDeMesa <= 40)
            {
                mesa.SetSeccion(4);
            }
            mesa.SetCantDeSillas(_cantSillas);

            colMesas.Add(mesa);
        }
    }
}
