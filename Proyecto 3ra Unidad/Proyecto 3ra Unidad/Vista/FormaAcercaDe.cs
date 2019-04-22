using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3ra_Unidad.Vista
{
    public partial class FormaAcercaDe : Form
    {
        public FormaAcercaDe()
        {
            InitializeComponent();
        }

        private void pictureBoxInicio_Click(object sender, EventArgs e)
        {
            Program.formaInicio.Show();
            Hide();
        }
    }
}
