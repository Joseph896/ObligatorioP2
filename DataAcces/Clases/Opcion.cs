using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class Opcion
    {
        public Opcion()
        {

        }

        private ushort numeroOpcion;
        private Tipo tipo;
        private string descripcion;
        private float cantidadCalorias;
        private float precio;
        private bool comandable;


        public enum Tipo
        {
            entrada,
            principal,
            postre,
            bebida
        };

        public ushort GetNumeroOpcion()
        {
            return this.numeroOpcion;
        }

        public Tipo GetTipo()
        {
            return this.tipo;
        }

        public string GetDescripcion()
        {
            return this.descripcion;
        }

        public float GetCalorias()
        {
            return this.cantidadCalorias;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public bool GetComandable()
        {
            return this.comandable;
        }

        public void SetNumeroOpcion(ushort _numeroOpcion)
        {
            this.numeroOpcion = _numeroOpcion;
        }

        public void SetTipo(Tipo _tipo)
        {
            this.tipo = _tipo;
        }

        public void SetDescripcion(string _descripcion)
        {
            this.descripcion = _descripcion;
        }

        public void SetCalorias(float _calorias)
        {
            this.cantidadCalorias = _calorias;
        }

        public void SetPrecio(float _precio)
        {
            this.precio = _precio;
        }

        public void SetComandable(bool _comandable)
        {
            this.comandable = _comandable;
        }
    }
}
