using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class Comanda
    {
        public Comanda()
        {

        }

        private byte numero;
        private Estado estado;
        private Cuenta cuenta;

        public enum Estado
        {
            Pendiente,
            EnPreparacion,
            Preparado
        };

        public byte GetNumero()
        {
            return this.numero;
        }

        public Estado GetEstado()
        {
            return this.estado;
        }

        public Cuenta GetCuenta()
        {
            return this.cuenta;
        }

        public void SetNumero(byte _numero)
        {
            this.numero = _numero;
        }

        public void SetEstado(Estado _estado)
        {
            this.estado = _estado;
        }

        public void SetCuenta(Cuenta _cuenta)
        {
            this.cuenta = _cuenta;
        }

        
    }
}
