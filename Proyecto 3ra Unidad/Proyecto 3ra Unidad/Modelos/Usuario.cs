using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ra_Unidad.Modelos
{
    class Usuario
    {
        public Usuario(string nombre, string password)
        {
            this.Nombre = nombre;
            this.Password = password;
        }

        public string Nombre { get; set; }
        public string Password { get; set; }        

    }
}
