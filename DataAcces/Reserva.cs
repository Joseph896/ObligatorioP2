using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class Reserva
    {
        public Reserva()
        {

        }

        private int numero;
        private byte cantidadComensales;
        private DateTime fechaHoraDeReserva;
        private Cliente cliente;
        private Mesa mesa;

        
        public int GetNumero()
        {
            return this.numero;
        }
        public byte GetCantidadComensales()
        {
            return this.cantidadComensales;
        }

        public DateTime GetFechaHoraReserva()
        {
            return this.fechaHoraDeReserva;
        }

        public Cliente GetCliente()
        {
            return this.cliente;
        }

        public Mesa GetMesa()
        {
            return this.mesa;
        }

        public void SetNumero(int _numero)
        {
            this.numero = _numero;
        }

        public void SetCantidadComensales(byte _cantidadComensales)
        {
            this.cantidadComensales = _cantidadComensales;
        }

        public void SetFechaHoraReserva(DateTime _fechaHoraReserva)
        {
            this.fechaHoraDeReserva = _fechaHoraReserva;
        }

        public void SetCliente(Cliente _cliente)
        {
            this.cliente = _cliente;
        }

        public void SetMesa(Mesa _mesa)
        {
            this.mesa = _mesa;
        }
    }
}
