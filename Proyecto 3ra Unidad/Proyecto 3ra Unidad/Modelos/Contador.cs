using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Contador
    {
        private int movidas;

        public Contador()
        {
            movidas = 0;
        }

        public int Movidas
        {
            get
            {
                return movidas;
            }

            set
            {
                movidas = value;
            }
        }
    }
}
