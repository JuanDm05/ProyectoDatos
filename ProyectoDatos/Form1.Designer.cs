namespace ProyectoDatos
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
            this.Limpiar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.RadioButton();
            this.color = new System.Windows.Forms.RadioButton();
            this.Descendente = new System.Windows.Forms.Button();
            this.Ascendnte = new System.Windows.Forms.Button();
            this.textmodificar = new System.Windows.Forms.TextBox();
            this.Long = new System.Windows.Forms.Label();
            this.txtlong = new System.Windows.Forms.TextBox();
            this.btnLongitudGuardar = new System.Windows.Forms.Button();
            this.radioButtonInicio = new System.Windows.Forms.RadioButton();
            this.radioButtonMedio = new System.Windows.Forms.RadioButton();
            this.radioButtonFinal = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(198, 79);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(188, 22);
            this.textnombre.TabIndex = 5;
            this.textnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(198, 149);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(188, 22);
            this.textprecio.TabIndex = 6;
            this.textprecio.TextChanged += new System.EventHandler(this.textprecio_TextChanged);
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(198, 214);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(188, 22);
            this.textcolor.TabIndex = 7;
            this.textcolor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(543, 251);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(36, 321);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(183, 321);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // dginstrumento
            // 
            this.dginstrumento.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dginstrumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginstrumento.Location = new System.Drawing.Point(5, 349);
            this.dginstrumento.Name = "dginstrumento";
            this.dginstrumento.RowHeadersWidth = 51;
            this.dginstrumento.RowTemplate.Height = 24;
            this.dginstrumento.Size = new System.Drawing.Size(593, 272);
            this.dginstrumento.TabIndex = 12;
            this.dginstrumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginstrumento_CellContentClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(342, 321);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(510, 212);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(147, 22);
            this.textbuscar.TabIndex = 16;
            this.textbuscar.TextChanged += new System.EventHandler(this.textbuscar_TextChanged);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(620, 315);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(101, 29);
            this.Limpiar.TabIndex = 18;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(480, 315);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(101, 29);
            this.Mostrar.TabIndex = 19;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(543, 151);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(67, 20);
            this.precio.TabIndex = 21;
            this.precio.TabStop = true;
            this.precio.Text = "Precio";
            this.precio.UseVisualStyleBackColor = true;
            this.precio.CheckedChanged += new System.EventHandler(this.precio_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(543, 125);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(77, 20);
            this.Nombre.TabIndex = 22;
            this.Nombre.TabStop = true;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.CheckedChanged += new System.EventHandler(this.Nombre_CheckedChanged);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(543, 177);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(60, 20);
            this.color.TabIndex = 23;
            this.color.TabStop = true;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // Descendente
            // 
            this.Descendente.Location = new System.Drawing.Point(603, 394);
            this.Descendente.Name = "Descendente";
            this.Descendente.Size = new System.Drawing.Size(118, 29);
            this.Descendente.TabIndex = 25;
            this.Descendente.Text = "Descendente";
            this.Descendente.UseVisualStyleBackColor = true;
            this.Descendente.Click += new System.EventHandler(this.Descendente_Click);
            // 
            // Ascendnte
            // 
            this.Ascendnte.Location = new System.Drawing.Point(603, 429);
            this.Ascendnte.Name = "Ascendnte";
            this.Ascendnte.Size = new System.Drawing.Size(118, 29);
            this.Ascendnte.TabIndex = 26;
            this.Ascendnte.Text = "Ascendente";
            this.Ascendnte.UseVisualStyleBackColor = true;
            this.Ascendnte.Click += new System.EventHandler(this.Ascendnte_Click);
            // 
            // textmodificar
            // 
            this.textmodificar.Location = new System.Drawing.Point(362, 456);
            this.textmodificar.Name = "textmodificar";
            this.textmodificar.Size = new System.Drawing.Size(100, 22);
            this.textmodificar.TabIndex = 15;
            this.textmodificar.TextChanged += new System.EventHandler(this.textmodificar_TextChanged);
            // 
            // Long
            // 
            this.Long.AutoSize = true;
            this.Long.Location = new System.Drawing.Point(33, 20);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(58, 16);
            this.Long.TabIndex = 30;
            this.Long.Text = "Longitud";
            // 
            // txtlong
            // 
            this.txtlong.Location = new System.Drawing.Point(198, 20);
            this.txtlong.Name = "txtlong";
            this.txtlong.Size = new System.Drawing.Size(188, 22);
            this.txtlong.TabIndex = 31;
            this.txtlong.TextChanged += new System.EventHandler(this.txtlong_TextChanged);
            // 
            // btnLongitudGuardar
            // 
            this.btnLongitudGuardar.Location = new System.Drawing.Point(411, 32);
            this.btnLongitudGuardar.Name = "btnLongitudGuardar";
            this.btnLongitudGuardar.Size = new System.Drawing.Size(75, 46);
            this.btnLongitudGuardar.TabIndex = 41;
            this.btnLongitudGuardar.Text = "Guardar Longitud";
            this.btnLongitudGuardar.UseVisualStyleBackColor = true;
            this.btnLongitudGuardar.Click += new System.EventHandler(this.btnLongitudGuardar_Click);
            // 
            // radioButtonInicio
            // 
            this.radioButtonInicio.AutoSize = true;
            this.radioButtonInicio.Location = new System.Drawing.Point(411, 148);
            this.radioButtonInicio.Name = "radioButtonInicio";
            this.radioButtonInicio.Size = new System.Drawing.Size(59, 20);
            this.radioButtonInicio.TabIndex = 43;
            this.radioButtonInicio.TabStop = true;
            this.radioButtonInicio.Text = "Inicio";
            this.radioButtonInicio.UseVisualStyleBackColor = true;
            this.radioButtonInicio.CheckedChanged += new System.EventHandler(this.radioButtonInicio_CheckedChanged);
            // 
            // radioButtonMedio
            // 
            this.radioButtonMedio.AutoSize = true;
            this.radioButtonMedio.Location = new System.Drawing.Point(411, 179);
            this.radioButtonMedio.Name = "radioButtonMedio";
            this.radioButtonMedio.Size = new System.Drawing.Size(66, 20);
            this.radioButtonMedio.TabIndex = 42;
            this.radioButtonMedio.TabStop = true;
            this.radioButtonMedio.Text = "Medio";
            this.radioButtonMedio.UseVisualStyleBackColor = true;
            this.radioButtonMedio.CheckedChanged += new System.EventHandler(this.radioButtonMedio_CheckedChanged);
            // 
            // radioButtonFinal
            // 
            this.radioButtonFinal.AutoSize = true;
            this.radioButtonFinal.Location = new System.Drawing.Point(411, 214);
            this.radioButtonFinal.Name = "radioButtonFinal";
            this.radioButtonFinal.Size = new System.Drawing.Size(57, 20);
            this.radioButtonFinal.TabIndex = 44;
            this.radioButtonFinal.TabStop = true;
            this.radioButtonFinal.Text = "Final";
            this.radioButtonFinal.UseVisualStyleBackColor = true;
            this.radioButtonFinal.CheckedChanged += new System.EventHandler(this.radioButtonFinal_CheckedChanged);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(411, 250);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(74, 20);
            this.radioButtonDefault.TabIndex = 45;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Original";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.radioButtonDefault_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Formas de insertar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Buscar por";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ordenar (Precio)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Volver menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoDatos.Properties.Resources.draw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonDefault);
            this.Controls.Add(this.radioButtonFinal);
            this.Controls.Add(this.radioButtonInicio);
            this.Controls.Add(this.radioButtonMedio);
            this.Controls.Add(this.btnLongitudGuardar);
            this.Controls.Add(this.txtlong);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.dginstrumento);
            this.Controls.Add(this.Ascendnte);
            this.Controls.Add(this.Descendente);
            this.Controls.Add(this.color);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Limpiar);
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
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.RadioButton precio;
        private System.Windows.Forms.RadioButton Nombre;
        private System.Windows.Forms.RadioButton color;
        private System.Windows.Forms.Button Descendente;
        private System.Windows.Forms.Button Ascendnte;
        private System.Windows.Forms.TextBox textmodificar;
        private System.Windows.Forms.Label Long;
        private System.Windows.Forms.TextBox txtlong;
        private System.Windows.Forms.Button btnLongitudGuardar;
        private System.Windows.Forms.RadioButton radioButtonInicio;
        private System.Windows.Forms.RadioButton radioButtonMedio;
        private System.Windows.Forms.RadioButton radioButtonFinal;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

