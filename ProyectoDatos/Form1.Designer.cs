﻿namespace ProyectoDatos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textcolor = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dginstrumento = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.irlistas = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.RadioButton();
            this.color = new System.Windows.Forms.RadioButton();
            this.Descendente = new System.Windows.Forms.Button();
            this.Ascendnte = new System.Windows.Forms.Button();
            this.textmodificar = new System.Windows.Forms.TextBox();
            this.IrPilas = new System.Windows.Forms.Button();
            this.IrColas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(218, 45);
            this.textnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(211, 26);
            this.textnombre.TabIndex = 5;
            this.textnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(218, 132);
            this.textprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(211, 26);
            this.textprecio.TabIndex = 6;
            this.textprecio.TextChanged += new System.EventHandler(this.textprecio_TextChanged);
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(218, 214);
            this.textcolor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(211, 26);
            this.textcolor.TabIndex = 7;
            this.textcolor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(605, 180);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(84, 29);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(40, 401);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(84, 29);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(206, 401);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(84, 29);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // dginstrumento
            // 
            this.dginstrumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginstrumento.Location = new System.Drawing.Point(6, 436);
            this.dginstrumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dginstrumento.Name = "dginstrumento";
            this.dginstrumento.RowHeadersWidth = 51;
            this.dginstrumento.RowTemplate.Height = 24;
            this.dginstrumento.Size = new System.Drawing.Size(667, 340);
            this.dginstrumento.TabIndex = 12;
            this.dginstrumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginstrumento_CellContentClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(385, 401);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 29);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(568, 131);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(165, 26);
            this.textbuscar.TabIndex = 16;
            this.textbuscar.TextChanged += new System.EventHandler(this.textbuscar_TextChanged);
            // 
            // irlistas
            // 
            this.irlistas.Location = new System.Drawing.Point(568, 235);
            this.irlistas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.irlistas.Name = "irlistas";
            this.irlistas.Size = new System.Drawing.Size(142, 29);
            this.irlistas.TabIndex = 17;
            this.irlistas.Text = "Ir a listas";
            this.irlistas.UseVisualStyleBackColor = true;
            this.irlistas.Click += new System.EventHandler(this.irlistas_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(697, 394);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(114, 36);
            this.Limpiar.TabIndex = 18;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(540, 394);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(114, 36);
            this.Mostrar.TabIndex = 19;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(605, 55);
            this.precio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(78, 24);
            this.precio.TabIndex = 21;
            this.precio.TabStop = true;
            this.precio.Text = "Precio";
            this.precio.UseVisualStyleBackColor = true;
            this.precio.CheckedChanged += new System.EventHandler(this.precio_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(605, 22);
            this.Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 24);
            this.Nombre.TabIndex = 22;
            this.Nombre.TabStop = true;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.CheckedChanged += new System.EventHandler(this.Nombre_CheckedChanged);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(605, 88);
            this.color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(71, 24);
            this.color.TabIndex = 23;
            this.color.TabStop = true;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // Descendente
            // 
            this.Descendente.Location = new System.Drawing.Point(687, 461);
            this.Descendente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Descendente.Name = "Descendente";
            this.Descendente.Size = new System.Drawing.Size(133, 36);
            this.Descendente.TabIndex = 25;
            this.Descendente.Text = "Descendente";
            this.Descendente.UseVisualStyleBackColor = true;
            this.Descendente.Click += new System.EventHandler(this.Descendente_Click);
            // 
            // Ascendnte
            // 
            this.Ascendnte.Location = new System.Drawing.Point(687, 505);
            this.Ascendnte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ascendnte.Name = "Ascendnte";
            this.Ascendnte.Size = new System.Drawing.Size(133, 36);
            this.Ascendnte.TabIndex = 26;
            this.Ascendnte.Text = "Ascendente";
            this.Ascendnte.UseVisualStyleBackColor = true;
            this.Ascendnte.Click += new System.EventHandler(this.Ascendnte_Click);
            // 
            // textmodificar
            // 
            this.textmodificar.Location = new System.Drawing.Point(407, 570);
            this.textmodificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textmodificar.Name = "textmodificar";
            this.textmodificar.Size = new System.Drawing.Size(112, 26);
            this.textmodificar.TabIndex = 15;
            this.textmodificar.TextChanged += new System.EventHandler(this.textmodificar_TextChanged);
            // 
            // IrPilas
            // 
            this.IrPilas.Location = new System.Drawing.Point(568, 272);
            this.IrPilas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IrPilas.Name = "IrPilas";
            this.IrPilas.Size = new System.Drawing.Size(142, 29);
            this.IrPilas.TabIndex = 28;
            this.IrPilas.Text = "Ir a pilas";
            this.IrPilas.UseVisualStyleBackColor = true;
            this.IrPilas.Click += new System.EventHandler(this.IrPilas_Click);
            // 
            // IrColas
            // 
            this.IrColas.Location = new System.Drawing.Point(568, 309);
            this.IrColas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IrColas.Name = "IrColas";
            this.IrColas.Size = new System.Drawing.Size(142, 29);
            this.IrColas.TabIndex = 29;
            this.IrColas.Text = "Ir a colas";
            this.IrColas.UseVisualStyleBackColor = true;
            this.IrColas.Click += new System.EventHandler(this.IrColas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 779);
            this.Controls.Add(this.IrColas);
            this.Controls.Add(this.IrPilas);
            this.Controls.Add(this.dginstrumento);
            this.Controls.Add(this.Ascendnte);
            this.Controls.Add(this.Descendente);
            this.Controls.Add(this.color);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.irlistas);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.textmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.textcolor);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textcolor;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView dginstrumento;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Button irlistas;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.RadioButton precio;
        private System.Windows.Forms.RadioButton Nombre;
        private System.Windows.Forms.RadioButton color;
        private System.Windows.Forms.Button Descendente;
        private System.Windows.Forms.Button Ascendnte;
        private System.Windows.Forms.TextBox textmodificar;
        private System.Windows.Forms.Button IrPilas;
        private System.Windows.Forms.Button IrColas;
    }
}

