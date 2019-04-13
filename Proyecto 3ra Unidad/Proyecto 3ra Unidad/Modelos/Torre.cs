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
            IdTorre = 0;
            AnchoT = 0;
            AltoT = 0;
            ColorT = 0;
        }

        public int IdTorre
        {
            get
            {
                return _idTorre;
            }

            set
            {
                _idTorre = value;
            }
        }
        public int AnchoT
        {
            get
            {
                return _anchoT;
            }

            set
            {
                _anchoT = value;
            }
        }
        public int AltoT
        {
            get
            {
                return _altoT;
            }

            set
            {
                _altoT = value;
            }
        }
        public int ColorT
        {
            get
            {
                return _colorT;
            }

            set
            {
                _colorT = value;
            }
        }
    }
}
