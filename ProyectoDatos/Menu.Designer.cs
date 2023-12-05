namespace ProyectoDatos
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncolas = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.BtnPilas = new System.Windows.Forms.Button();
            this.Arreglos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.btncolas);
            this.panel1.Controls.Add(this.btnListas);
            this.panel1.Controls.Add(this.BtnPilas);
            this.panel1.Controls.Add(this.Arreglos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 624);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btncolas
            // 
            this.btncolas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncolas.Image = global::ProyectoDatos.Properties.Resources.cola;
            this.btncolas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncolas.Location = new System.Drawing.Point(0, 256);
            this.btncolas.Name = "btncolas";
            this.btncolas.Size = new System.Drawing.Size(219, 63);
            this.btncolas.TabIndex = 4;
            this.btncolas.Text = "Colas";
            this.btncolas.UseVisualStyleBackColor = true;
            this.btncolas.Click += new System.EventHandler(this.btncolas_Click);
            // 
            // btnListas
            // 
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListas.Image = global::ProyectoDatos.Properties.Resources.ordenar;
            this.btnListas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListas.Location = new System.Drawing.Point(1, 137);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(218, 63);
            this.btnListas.TabIndex = 3;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // BtnPilas
            // 
            this.BtnPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPilas.Image = global::ProyectoDatos.Properties.Resources.libros;
            this.BtnPilas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPilas.Location = new System.Drawing.Point(0, 197);
            this.BtnPilas.Name = "BtnPilas";
            this.BtnPilas.Size = new System.Drawing.Size(219, 63);
            this.BtnPilas.TabIndex = 2;
            this.BtnPilas.Text = "Pilas";
            this.BtnPilas.UseVisualStyleBackColor = true;
            this.BtnPilas.Click += new System.EventHandler(this.BtnPilas_Click);
            // 
            // Arreglos
            // 
            this.Arreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arreglos.Image = global::ProyectoDatos.Properties.Resources.matriz__2_;
            this.Arreglos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Arreglos.Location = new System.Drawing.Point(1, 78);
            this.Arreglos.Name = "Arreglos";
            this.Arreglos.Size = new System.Drawing.Size(219, 63);
            this.Arreglos.TabIndex = 1;
            this.Arreglos.Text = "Arreglo";
            this.Arreglos.UseVisualStyleBackColor = true;
            this.Arreglos.Click += new System.EventHandler(this.Arreglos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 80);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrumentos Musicales";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoDatos.Properties.Resources.violina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 452);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Arreglos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncolas;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button BtnPilas;
        private System.Windows.Forms.Label label1;
    }
}