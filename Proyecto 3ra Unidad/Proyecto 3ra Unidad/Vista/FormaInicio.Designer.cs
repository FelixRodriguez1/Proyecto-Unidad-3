﻿namespace Proyecto_3ra_Unidad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureSalir = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonResultados = new System.Windows.Forms.Button();
            this.buttonComoJugar = new System.Windows.Forms.Button();
            this.buttonAcercaDe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelTitulo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureSalir);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(459, 377);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(459, 60);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Torre de Hanoi";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureSalir
            // 
            this.pictureSalir.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureSalir.Image = ((System.Drawing.Image)(resources.GetObject("pictureSalir.Image")));
            this.pictureSalir.Location = new System.Drawing.Point(356, 258);
            this.pictureSalir.Name = "pictureSalir";
            this.pictureSalir.Size = new System.Drawing.Size(100, 50);
            this.pictureSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSalir.TabIndex = 3;
            this.pictureSalir.TabStop = false;
            this.pictureSalir.Click += new System.EventHandler(this.pictureSalir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.buttonIniciar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonResultados, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonComoJugar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAcercaDe, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIniciar.Location = new System.Drawing.Point(101, 41);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(268, 31);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Juego Nuevo";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonJuego_Click);
            // 
            // buttonResultados
            // 
            this.buttonResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResultados.Location = new System.Drawing.Point(101, 78);
            this.buttonResultados.Name = "buttonResultados";
            this.buttonResultados.Size = new System.Drawing.Size(268, 29);
            this.buttonResultados.TabIndex = 1;
            this.buttonResultados.Text = "Resultados";
            this.buttonResultados.UseVisualStyleBackColor = true;
            this.buttonResultados.Click += new System.EventHandler(this.buttonResultados_Click);
            // 
            // buttonComoJugar
            // 
            this.buttonComoJugar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComoJugar.Location = new System.Drawing.Point(101, 113);
            this.buttonComoJugar.Name = "buttonComoJugar";
            this.buttonComoJugar.Size = new System.Drawing.Size(268, 30);
            this.buttonComoJugar.TabIndex = 2;
            this.buttonComoJugar.Text = "Como jugar";
            this.buttonComoJugar.UseVisualStyleBackColor = true;
            this.buttonComoJugar.Click += new System.EventHandler(this.buttonComoJugar_Click);
            // 
            // buttonAcercaDe
            // 
            this.buttonAcercaDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAcercaDe.Location = new System.Drawing.Point(101, 149);
            this.buttonAcercaDe.Name = "buttonAcercaDe";
            this.buttonAcercaDe.Size = new System.Drawing.Size(268, 31);
            this.buttonAcercaDe.TabIndex = 3;
            this.buttonAcercaDe.Text = "Acerca De";
            this.buttonAcercaDe.UseVisualStyleBackColor = true;
            this.buttonAcercaDe.Click += new System.EventHandler(this.buttonAcercaDe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 377);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSalir)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonResultados;
        private System.Windows.Forms.Button buttonComoJugar;
        private System.Windows.Forms.Button buttonAcercaDe;
    }
}

