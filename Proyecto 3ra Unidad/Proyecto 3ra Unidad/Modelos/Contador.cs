using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Contador
    {
        private long _tiempo;
        private int _movimientos;

        public Contador()
        {
            _tiempo = 0;
            _movimientos = 0;
        }
        public long Tiempo { get; set; }
        public int Movimientos { get; set; }
    }
}
