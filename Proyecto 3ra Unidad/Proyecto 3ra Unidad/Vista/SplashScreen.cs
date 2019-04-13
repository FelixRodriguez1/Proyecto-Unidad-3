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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //El temporizador dara inicio desde aqui
            timeLeft = 50;
            timer1.Start();
        }

        public int timeLeft { get; set; }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

            }
            else
            {
                timer1.Stop();
                new FormaIniciarSesion().Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
