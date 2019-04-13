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
        protected List<Disco> _numDiscos;
        
        protected int _numTorres;

        public TorreHanoi()
        {
            _idJuego = 0;
            _numDiscos= new List<Disco>();
            _numTorres = 0;
        }

        public int IdJuego { get; set; }
        public int NumDiscos { get; set; }
        public int NumTorres { get; set; }
    }
}
