using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Proyecto_3ra_Unidad.Vista;
using Proyecto_3ra_Unidad.Properties;


namespace Proyecto_3ra_Unidad.Modelos
{
    class TorreHanoi
    {
        protected int _idJuego;
        protected int _numTorres;
        protected int _movidas;
        protected int _discos;

        public TorreHanoi()
        {
            _idJuego = 1;
            _numTorres = 3;
            _movidas = 1;
            _discos = 1;
        }

        public int Movidas
        {
            get
            {
                return _movidas;
            }

            set
            {
                _movidas = value;
            }
        }

        protected int IdJuego
        {
            get
            {
                return _idJuego;
            }

            set
            {
                _idJuego = value;
            }
        }

        protected int NumTorres
        {
            get
            {
                return _numTorres;
            }

            set
            {
                _numTorres = value;
            }
        }

        public int Discos
        {
            get
            {
                return _discos;
            }

            set
            {
                _discos = value;
            }
        }

    }
}
