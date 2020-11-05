using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    class Comanda
    {
        private byte numero;
        private Estado estado;
        private List<Opcion> opciones;
        private Mozo mozo;

        enum Estado
        {
            Pendiente,
            EnPreparacion,
            Preparado
        }
    }
}
