﻿using Proyecto_3ra_Unidad.Modelos;
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
    public partial class FormaIniciarSesion : Form
    {
        public FormaIniciarSesion()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.TextLength > 3 && textBoxUsuario.TextLength <= 50 && textBoxContraseña.TextLength >= 4 && textBoxContraseña.TextLength < 30)
            {
                if (loginHelper.Autenticar(textBoxUsuario.Text, textBoxContraseña.Text))
                {
                    MessageBox.Show("Bienvenido!");
                    Program.formaInicio.Show();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario y contraseña Incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario y contraseña Incorrectos");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}