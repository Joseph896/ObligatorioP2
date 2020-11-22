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

        public Mesa(short _nroDeMesa, short _seccion, short _cantDeSillas)
        {
            this.nroDeMesa = _nroDeMesa;
            this.seccion = _seccion;
            this.cantDeSillas = _cantDeSillas;
        }

        private short nroDeMesa;
        private short seccion;
        private short cantDeSillas;
        private Reserva reserva;

        public short GetNroDeMesa()
        {
            return this.nroDeMesa;
        }

        public short GetSeccion()
        {
            return this.seccion;
        }

        public short GetCantDeSillas()
        {
            return this.cantDeSillas;
        }

        public Reserva GetReserva()
        {
            return this.reserva;
        }

        public void SetNroDeMesa(short _nroDeMesa)
        {
            this.nroDeMesa = _nroDeMesa;
        }

        public void SetSeccion(short _seccion)
        {
            this.seccion = _seccion;
        }

        public void SetCantDeSillas(short _cantDeSillas)
        {
            this.cantDeSillas = _cantDeSillas;
        }

        public void SetReserva(Reserva _reserva)
        {
            this.reserva = _reserva;
        }
    }
}
