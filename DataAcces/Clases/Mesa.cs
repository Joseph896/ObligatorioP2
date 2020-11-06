using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class Mesa
    {
        public Mesa()
        {

        }

        private ushort nroDeMesa;
        private byte seccion;
        private ushort cantDeSillas;
        private Reserva reserva;

        public ushort GetNroDeMesa()
        {
            return this.nroDeMesa;
        }

        public byte GetSeccion()
        {
            return this.seccion;
        }

        public ushort GetCantDeSillas()
        {
            return this.cantDeSillas;
        }

        public Reserva GetReserva()
        {
            return this.reserva;
        }

        public void SetNroDeMesa(ushort _nroDeMesa)
        {
            this.nroDeMesa = _nroDeMesa;
        }

        public void SetSeccion(byte _seccion)
        {
            this.seccion = _seccion;
        }

        public void SetCantDeSillas(ushort _cantDeSillas)
        {
            this.cantDeSillas = _cantDeSillas;
        }

        public void SetReserva(Reserva _reserva)
        {
            this.reserva = _reserva;
        }
    }
}
