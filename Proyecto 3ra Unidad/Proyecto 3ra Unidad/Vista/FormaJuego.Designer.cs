namespace Proyecto_3ra_Unidad.Vista
{
    partial class FormaJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaJuego));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cambiarDiscos = new System.Windows.Forms.ComboBox();
            this.labelMovidas = new System.Windows.Forms.Label();
            this.torre3 = new System.Windows.Forms.GroupBox();
            this.torre2 = new System.Windows.Forms.GroupBox();
            this.torre1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.torre3);
            this.splitContainer1.Panel2.Controls.Add(this.torre2);
            this.splitContainer1.Panel2.Controls.Add(this.torre1);
            this.splitContainer1.Size = new System.Drawing.Size(746, 447);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cambiarDiscos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMovidas, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(570, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. Discos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movimientos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cambiarDiscos
            // 
            this.cambiarDiscos.FormattingEnabled = true;
            this.cambiarDiscos.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cambiarDiscos.Location = new System.Drawing.Point(125, 45);
            this.cambiarDiscos.Name = "cambiarDiscos";
            this.cambiarDiscos.Size = new System.Drawing.Size(55, 21);
            this.cambiarDiscos.TabIndex = 6;
            this.cambiarDiscos.Text = "3";
            this.cambiarDiscos.SelectedIndexChanged += new System.EventHandler(this.cambiarDiscos_SelectedIndexChanged);
            // 
            // labelMovidas
            // 
            this.labelMovidas.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMovidas.Font = new System.Drawing.Font("Arial", 12F);
            this.labelMovidas.Location = new System.Drawing.Point(125, 83);
            this.labelMovidas.Name = "labelMovidas";
            this.labelMovidas.Size = new System.Drawing.Size(100, 53);
            this.labelMovidas.TabIndex = 5;
            this.labelMovidas.Text = "0";
            // 
            // torre3
            // 
            this.torre3.Location = new System.Drawing.Point(490, 56);
            this.torre3.Name = "torre3";
            this.torre3.Size = new System.Drawing.Size(190, 220);
            this.torre3.TabIndex = 2;
            this.torre3.TabStop = false;
            // 
            // torre2
            // 
            this.torre2.Location = new System.Drawing.Point(270, 56);
            this.torre2.Name = "torre2";
            this.torre2.Size = new System.Drawing.Size(190, 220);
            this.torre2.TabIndex = 1;
            this.torre2.TabStop = false;
            // 
            // torre1
            // 
            this.torre1.BackColor = System.Drawing.SystemColors.Control;
            this.torre1.Location = new System.Drawing.Point(44, 56);
            this.torre1.Name = "torre1";
            this.torre1.Size = new System.Drawing.Size(190, 220);
            this.torre1.TabIndex = 0;
            this.torre1.TabStop = false;
            // 
            // FormaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 447);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormaJuego_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox torre3;
        private System.Windows.Forms.GroupBox torre2;
        private System.Windows.Forms.GroupBox torre1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cambiarDiscos;
        private System.Windows.Forms.Label labelMovidas;
    }
}