using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_3ra_Unidad.Modelos
{
    class loginHelper
    {
        public static List<Usuario> GetUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (StreamReader sr = new StreamReader("C:\\Users\\locog\\OneDrive\\Escritorio\\Usuarios.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] infousu = line.Split(',');
                    Usuario usu = new Usuario(infousu[0], infousu[1]);
                    lista.Add(usu);
                }
            }

            return lista;

        }

        public static bool Autenticar(string nombre, string password)
        {
            bool result = false;
            List<Usuario> lista = GetUsuarios();

            foreach (Usuario usu in lista)
            {
                if (usu.Nombre == nombre && usu.Password == password)
                {
                    result = true;
                    break;
                }

            }

            return result;
        }

    }
}
