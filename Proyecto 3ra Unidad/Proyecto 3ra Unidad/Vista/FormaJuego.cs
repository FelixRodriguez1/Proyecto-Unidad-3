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
using Proyecto_3ra_Unidad.Modelos;
using Proyecto_3ra_Unidad.Properties;
using System.IO;

namespace Proyecto_3ra_Unidad.Vista
{
    public partial class FormaJuego : Form
    {

        public string ruta;
        private int alturaDisco = 25;
        public int movidas = 1;
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }*/
        public FormaJuego()
        {
            components = null;
            alturaDisco = 25;
            movidas = 1;
            InitializeComponent();
            ruta = "C:\\Users\\locog\\OneDrive\\Escritorio\\Resultados.txt";
        }

        private void buttonResultados_Click(object sender, EventArgs e)
        {
            Program.formaResultados.Show();
            Hide();
        }

        private void FormaJuego_Load(object sender, EventArgs e)
        {
            agregarAnillos(3u);
            torre1.AllowDrop = true;
            torre2.AllowDrop = true;
            torre3.AllowDrop = true;
            torre1.DragEnter += new DragEventHandler(FormaJuego.DiscoArrastrar_DragEnter);
            torre1.DragDrop += new DragEventHandler(DiscoSoltar_DragDrop);
            torre2.DragEnter += new DragEventHandler(FormaJuego.DiscoArrastrar_DragEnter);
            torre2.DragDrop += new DragEventHandler(DiscoSoltar_DragDrop);
            torre3.DragEnter += new DragEventHandler(FormaJuego.DiscoArrastrar_DragEnter);
            torre3.DragDrop += new DragEventHandler(DiscoSoltar_DragDrop);
        }

        public void agregarAnillos(uint Cant_Discos)
        {
            torre1.Controls.Clear();
            torre2.Controls.Clear();
            torre3.Controls.Clear();
            int num = 1;
            while (num <= (long)((ulong)Cant_Discos))
            {
                Button button = new Button();
                button.AutoSize = false;
                int num2 = 190 * (10 - num + 1) / 10;
                button.Location = new Point((190 - num2) / 2, torre1.Height - alturaDisco * num);
                button.Name = "disco" + num;
                button.Size = new Size(num2, alturaDisco);
                button.Text = ((long)(Cant_Discos - (ulong)num + 1uL)).ToString();
                button.Tag = num;
                button.MouseDown += new MouseEventHandler(Disco_MouseDown);
                torre1.Controls.Add(button);
                Random random = new Random();
                button.BackColor = Color.FromArgb(random.Next(0, 226), random.Next(0, 206), random.Next(0, 196));
                button.FlatStyle = FlatStyle.Standard;
                button.BackgroundImage = Resources.disco2;
                num++;
            }
        }

        private void Disco_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            if (FormaJuego.DiscoSuperiorTorre(button.Parent, button))
            {
                DataObject data = new DataObject("disco", button);
                ((Button)sender).DoDragDrop(data, DragDropEffects.Move);
            }
        }

        private void DiscoSoltar_DragDrop(object sender, DragEventArgs e)
        {
            
            GroupBox groupBox = (GroupBox)sender;
            Button button = e.Data.GetData("disco") as Button;
            if (groupBox != button.Parent)
            {
                Button button2 = FormaJuego.ObtenerDiscoSuperiorTorre(groupBox);
                int top = groupBox.Height - alturaDisco;
                if (button2 != null)
                {
                    if ((int)button2.Tag > (int)button.Tag)
                    {
                        return;
                    }
                    top = button2.Top - alturaDisco;
                }
                button.Top = top;
                button.Parent.Controls.Remove(button);
                groupBox.Controls.Add(button);
                labelMovidas.Text = Convert.ToString(movidas++);
                if (groupBox.Name.ToString() == "torre3" && groupBox.Controls.Count == Convert.ToUInt16(cambiarDiscos.Text))
                {
                    MessageBox.Show("Terminaste en: " + labelMovidas.Text + " Movimientos\n\nTu torre fue de: " + cambiarDiscos.Text + " Discos");
                    StreamWriter resultado = new StreamWriter(ruta, true);
                    resultado.WriteLine(labelMovidas.Text + "|" + cambiarDiscos.Text);
                    resultado.Close();
                    agregarAnillos(Convert.ToUInt16(cambiarDiscos.Text));
                    labelMovidas.Text = "0";
                    movidas = 1;
                }
            }
        }
        private static void DiscoArrastrar_DragEnter(object sender, DragEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;
            Button button = e.Data.GetData("disco") as Button;
            if (groupBox != button.Parent)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private static bool DiscoSuperiorTorre(Control group, Control btnDisk)
        {
            Button button = FormaJuego.ObtenerDiscoSuperiorTorre(group);
            return button == null || (int)button.Tag <= (int)btnDisk.Tag;
        }

        private static Button ObtenerDiscoSuperiorTorre(Control group, Control btnDisk)
        {
            Button button = null;
            foreach (Control control in group.Controls)
            {
                if (control is Button && (button == null || (int)control.Tag > (int)button.Tag))
                {
                    button = (Button)control;
                }
            }
            return button;
        }

        private void cambiarDiscos_SelectedIndexChanged(object sender, EventArgs e)
        {
            agregarAnillos(Convert.ToUInt16(cambiarDiscos.Text));
            labelMovidas.Text = "0";
            movidas = 1;
        }

        private static Button ObtenerDiscoSuperiorTorre(Control group)
        {
            Button button = null;
            foreach (Control control in group.Controls)
            {
                if (control is Button && (button == null || (int)control.Tag > (int)button.Tag))
                {
                    button = (Button)control;
                }
            }
            return button;
        }

        private void pictureInicio_Click(object sender, EventArgs e)
        {
            Program.formaInicio.Show();
            Dispose();
        }
    }
}
