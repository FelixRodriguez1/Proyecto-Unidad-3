﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Resultado : TorreHanoi
    {
        private int _posicionJu;

        public Resultado() : base()
        {
            PosicionJu = 0;
        }

        public int PosicionJu
        {
            get
            {
                return _posicionJu;
            }

            set
            {
                _posicionJu = value;
            }
        }
    }
}
