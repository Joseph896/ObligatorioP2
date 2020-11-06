using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class Cuenta
    {
        public Cuenta()
        {

        }

        private long numeroDeCuenta;
        private DateTime fechaIngreso;
        private DateTime fechaCierre;
        private float precioTotal;
        private List<Opcion> opciones;
        private Mesa mesa;
        private Mozo mozo;

        public long GetNumero()
        {
            return this.numeroDeCuenta;
        }

        public DateTime GetFechaIngreso()
        {
            return this.fechaIngreso;
        }

        public DateTime GetFechaCierre()
        {
            return this.fechaCierre;
        }

        public float GetPrecioTotal()
        {
            return this.precioTotal;
        }

        public List<Opcion> GetOpciones()
        {
            return this.opciones;
        }

        public Mesa GetMesa()
        {
            return this.mesa;
        }

        public Mozo GetMozo()
        {
            return this.mozo;
        }

        public void SetNumero(long _numero)
        {
            this.numeroDeCuenta = _numero;
        }

        public void SetFechaIngreso(DateTime _fechaIngreso)
        {
            this.fechaIngreso = _fechaIngreso;
        }

        public void SetFechaCierre(DateTime _fechaCierre)
        {
            this.fechaCierre = _fechaCierre;
        }

        public void SetPrecioTotal(float _precioTotal)
        {
            this.precioTotal = _precioTotal;
        }

        public void SetOpciones(List<Opcion> _opciones)
        {
            this.opciones = _opciones;
        }

        public void SetMesa(Mesa _mesa)
        {
            this.mesa = _mesa;
        }

        public void SetMozo(Mozo _mozo)
        {
            this.mozo = _mozo;
        }
    }
}
