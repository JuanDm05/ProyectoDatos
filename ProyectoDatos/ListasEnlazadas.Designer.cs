namespace ProyectoDatos
{
    partial class ListasEnlazadas
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
            this.textcolor = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dginstrumento = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.Decendente = new System.Windows.Forms.Button();
            this.Ascendente = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.RadioButton();
            this.precio = new System.Windows.Forms.RadioButton();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarFinal = new System.Windows.Forms.Button();
            this.btnGuardarMedio = new System.Windows.Forms.Button();
            this.btnGuardarInicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(177, 200);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(188, 22);
            this.textcolor.TabIndex = 13;
            this.textcolor.TextChanged += new System.EventHandler(this.textcolor_TextChanged);
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(177, 138);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(188, 22);
            this.textprecio.TabIndex = 12;
            this.textprecio.TextChanged += new System.EventHandler(this.textprecio_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(177, 66);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(188, 22);
            this.textnombre.TabIndex = 11;
            this.textnombre.TextChanged += new System.EventHandler(this.textnombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listas enlazadas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(319, 250);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 19;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dginstrumento
            // 
            this.dginstrumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginstrumento.Location = new System.Drawing.Point(12, 280);
            this.dginstrumento.Name = "dginstrumento";
            this.dginstrumento.RowHeadersWidth = 51;
            this.dginstrumento.RowTemplate.Height = 24;
            this.dginstrumento.Size = new System.Drawing.Size(593, 272);
            this.dginstrumento.TabIndex = 18;
            this.dginstrumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginstrumento_CellContentClick);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(177, 251);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 17;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(36, 251);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Decendente
            // 
            this.Decendente.Location = new System.Drawing.Point(624, 326);
            this.Decendente.Name = "Decendente";
            this.Decendente.Size = new System.Drawing.Size(139, 26);
            this.Decendente.TabIndex = 24;
            this.Decendente.Text = "Decendente";
            this.Decendente.UseVisualStyleBackColor = true;
            this.Decendente.Click += new System.EventHandler(this.Decendente_Click);
            // 
            // Ascendente
            // 
            this.Ascendente.Location = new System.Drawing.Point(624, 358);
            this.Ascendente.Name = "Ascendente";
            this.Ascendente.Size = new System.Drawing.Size(139, 26);
            this.Ascendente.TabIndex = 25;
            this.Ascendente.Text = "Ascendente";
            this.Ascendente.UseVisualStyleBackColor = true;
            this.Ascendente.Click += new System.EventHandler(this.Ascendente_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(530, 250);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Mostrar.TabIndex = 26;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(664, 251);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 27;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(613, 66);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(60, 20);
            this.color.TabIndex = 32;
            this.color.TabStop = true;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(613, 14);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(77, 20);
            this.Nombre.TabIndex = 31;
            this.Nombre.TabStop = true;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.CheckedChanged += new System.EventHandler(this.Nombre_CheckedChanged);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(613, 40);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(67, 20);
            this.precio.TabIndex = 30;
            this.precio.TabStop = true;
            this.precio.Text = "Precio";
            this.precio.UseVisualStyleBackColor = true;
            this.precio.CheckedChanged += new System.EventHandler(this.precio_CheckedChanged);
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(571, 93);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(147, 22);
            this.textbuscar.TabIndex = 29;
            this.textbuscar.TextChanged += new System.EventHandler(this.textbuscar_TextChanged_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(598, 121);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ordenar (Precio)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Formas de insertar";
            // 
            // btnGuardarFinal
            // 
            this.btnGuardarFinal.Location = new System.Drawing.Point(434, 215);
            this.btnGuardarFinal.Name = "btnGuardarFinal";
            this.btnGuardarFinal.Size = new System.Drawing.Size(75, 47);
            this.btnGuardarFinal.TabIndex = 40;
            this.btnGuardarFinal.Text = "Guardar Final";
            this.btnGuardarFinal.UseVisualStyleBackColor = true;
            this.btnGuardarFinal.Click += new System.EventHandler(this.btnGuardarFinal_Click);
            // 
            // btnGuardarMedio
            // 
            this.btnGuardarMedio.Location = new System.Drawing.Point(434, 150);
            this.btnGuardarMedio.Name = "btnGuardarMedio";
            this.btnGuardarMedio.Size = new System.Drawing.Size(75, 59);
            this.btnGuardarMedio.TabIndex = 41;
            this.btnGuardarMedio.Text = "Guardar Medio";
            this.btnGuardarMedio.UseVisualStyleBackColor = true;
            this.btnGuardarMedio.Click += new System.EventHandler(this.btnGuardarMedio_Click);
            // 
            // btnGuardarInicio
            // 
            this.btnGuardarInicio.Location = new System.Drawing.Point(434, 93);
            this.btnGuardarInicio.Name = "btnGuardarInicio";
            this.btnGuardarInicio.Size = new System.Drawing.Size(75, 51);
            this.btnGuardarInicio.TabIndex = 42;
            this.btnGuardarInicio.Text = "Guardar Inicio";
            this.btnGuardarInicio.UseVisualStyleBackColor = true;
            this.btnGuardarInicio.Click += new System.EventHandler(this.btnGuardarInicio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Volver menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListasEnlazadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoDatos.Properties.Resources.draw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarInicio);
            this.Controls.Add(this.btnGuardarMedio);
            this.Controls.Add(this.btnGuardarFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.color);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Ascendente);
            this.Controls.Add(this.Decendente);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dginstrumento);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcolor);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ListasEnlazadas";
            this.Text = "ListasEnlazadas";
            this.Load += new System.EventHandler(this.ListasEnlazadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcolor;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dginstrumento;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button Decendente;
        private System.Windows.Forms.Button Ascendente;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.RadioButton color;
        private System.Windows.Forms.RadioButton Nombre;
        private System.Windows.Forms.RadioButton precio;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarFinal;
        private System.Windows.Forms.Button btnGuardarMedio;
        private System.Windows.Forms.Button btnGuardarInicio;
        private System.Windows.Forms.Button button1;
    }
}