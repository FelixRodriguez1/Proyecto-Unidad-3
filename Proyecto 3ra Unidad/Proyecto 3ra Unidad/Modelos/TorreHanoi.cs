using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class TorreHanoi
    {
        protected int _idJuego;
        protected int _numDiscos;
        protected int _numTorres;

        public TorreHanoi()
        {
            _idJuego = 0;
            _numDiscos = 0;
            _numTorres = 0;
        }

        public int IdJuego { get; set; }
        public int NumDiscos { get; set; }
        public int NumTorres { get; set; }
    }
}
