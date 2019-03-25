using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Torre
    {
        private int _idTorre;
        private int _anchoT;
        private int _altoT;
        private int _colorT;

        public Torre()
        {
            _idTorre = 0;
            _anchoT = 0;
            _altoT = 0;
            _colorT = 0;
        }

        public int IdTorre { get; set; }
        public int AnchoT { get; set; }
        public int AltoT { get; set; }
        public int ColorT { get; set; }
    }
}
