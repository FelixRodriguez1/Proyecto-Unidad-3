using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_3ra_Unidad.Vista;

namespace Proyecto_3ra_Unidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJuego_Click(object sender, EventArgs e)
        {
            Program.formaJuego.Show();
            Hide();
        }

        private void buttonResultados_Click(object sender, EventArgs e)
        {
            Program.formaResultados.Show();
            Hide();
        }
        private void buttonComoJugar_Click(object sender, EventArgs e)
        {
            Program.formaComoJugar.Show();
            Hide();
        }

        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            Program.formaAcercaDe.Show();
            Hide();
        }

        private void pictureSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
