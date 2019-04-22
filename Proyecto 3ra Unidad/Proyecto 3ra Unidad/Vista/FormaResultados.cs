using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proyecto_3ra_Unidad.Vista;

namespace Proyecto_3ra_Unidad.Vista
{
    public partial class FormaResultados : Form
    {
        public string ruta1;
        public FormaResultados()
        {
            InitializeComponent();
            ruta1 = "C:\\Users\\locog\\OneDrive\\Escritorio\\Resultados.txt";
        }

        private void pictureInicio_Click(object sender, EventArgs e)
        {
            Program.formaInicio.Show();
            Hide();
        }

        private void FormaResultados_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void loadGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string text;
            StreamReader resultado1 = new StreamReader(ruta1, Encoding.Default);
            while ((text = resultado1.ReadLine()) != null)
            {
                //Lee cada linea a partiendola a traves del caracter
                string[] array = text.Split('|');
                dataGridView1.Rows.Add(array); // Agrega un renglon
            }
            resultado1.Close();
        }
    }
}
