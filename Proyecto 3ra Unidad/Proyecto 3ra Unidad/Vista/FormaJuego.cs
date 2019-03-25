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

namespace Proyecto_3ra_Unidad.Vista
{
    public partial class FormaJuego : Form
    {
        public FormaJuego()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1();
            forma.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaFinJuego forma = new FormaFinJuego();
            forma.Show();
            this.Dispose();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
