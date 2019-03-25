using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Disco
    {
        private int _idDisco;
        private int _anchoD;
        private int _altoD;
        private int _colorD;

        public Disco()
        {
            _idDisco = 1;
            _anchoD = 0;
            _altoD = 0;
            _colorD = 0;
        }

        public int IdDisco { get; set; }
        public int AnchoD { get; set; }
        public int AltoD { get; set; }
        public int ColorD { get; set; }
    }
}
