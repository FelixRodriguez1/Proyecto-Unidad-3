using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Contador
    {
        private int _movimientos;

        public Contador()
        {
            Movimientos = 0;
        }

        public int Movimientos
        {
            get
            {
                return _movimientos;
            }

            set
            {
                _movimientos = value;
            }
        }
    }
}
