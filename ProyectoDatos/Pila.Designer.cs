namespace ProyectoDatos
{
    partial class Pila
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
            this.dginstrumento = new System.Windows.Forms.DataGridView();
            this.Ascendnte = new System.Windows.Forms.Button();
            this.Descendente = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.RadioButton();
            this.precio = new System.Windows.Forms.RadioButton();
            this.Mostrar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.textcolor = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).BeginInit();
            this.SuspendLayout();
            // 
            // dginstrumento
            // 
            this.dginstrumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginstrumento.Location = new System.Drawing.Point(49, 426);
            this.dginstrumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dginstrumento.Name = "dginstrumento";
            this.dginstrumento.RowHeadersWidth = 51;
            this.dginstrumento.RowTemplate.Height = 24;
            this.dginstrumento.Size = new System.Drawing.Size(660, 229);
            this.dginstrumento.TabIndex = 36;
            this.dginstrumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dginstrumento_CellContentClick);
            // 
            // Ascendnte
            // 
            this.Ascendnte.Location = new System.Drawing.Point(720, 316);
            this.Ascendnte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ascendnte.Name = "Ascendnte";
            this.Ascendnte.Size = new System.Drawing.Size(133, 36);
            this.Ascendnte.TabIndex = 46;
            this.Ascendnte.Text = "Ascendente";
            this.Ascendnte.UseVisualStyleBackColor = true;
            this.Ascendnte.Click += new System.EventHandler(this.Ascendnte_Click);
            // 
            // Descendente
            // 
            this.Descendente.Location = new System.Drawing.Point(720, 272);
            this.Descendente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Descendente.Name = "Descendente";
            this.Descendente.Size = new System.Drawing.Size(133, 36);
            this.Descendente.TabIndex = 45;
            this.Descendente.Text = "Descendente";
            this.Descendente.UseVisualStyleBackColor = true;
            this.Descendente.Click += new System.EventHandler(this.Descendente_Click);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(741, 130);
            this.color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(71, 24);
            this.color.TabIndex = 44;
            this.color.TabStop = true;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(741, 64);
            this.Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 24);
            this.Nombre.TabIndex = 43;
            this.Nombre.TabStop = true;
            this.Nombre.Text = "Nombre";
            this.Nombre.UseVisualStyleBackColor = true;
            this.Nombre.CheckedChanged += new System.EventHandler(this.Nombre_CheckedChanged);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(741, 97);
            this.precio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(78, 24);
            this.precio.TabIndex = 42;
            this.precio.TabStop = true;
            this.precio.Text = "Precio";
            this.precio.UseVisualStyleBackColor = true;
            this.precio.CheckedChanged += new System.EventHandler(this.precio_CheckedChanged);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(663, 382);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(74, 36);
            this.Mostrar.TabIndex = 41;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(812, 382);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(114, 36);
            this.Limpiar.TabIndex = 40;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(704, 173);
            this.textbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(165, 26);
            this.textbuscar.TabIndex = 38;
            this.textbuscar.TextChanged += new System.EventHandler(this.textbuscar_TextChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(405, 389);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 29);
            this.btneliminar.TabIndex = 37;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(226, 389);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(84, 29);
            this.btnmodificar.TabIndex = 35;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(60, 389);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(84, 29);
            this.btnguardar.TabIndex = 34;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(741, 222);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(84, 29);
            this.btnbuscar.TabIndex = 33;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(251, 321);
            this.textcolor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(211, 26);
            this.textcolor.TabIndex = 32;
            this.textcolor.TextChanged += new System.EventHandler(this.textcolor_TextChanged);
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(251, 239);
            this.textprecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(211, 26);
            this.textprecio.TabIndex = 31;
            this.textprecio.TextChanged += new System.EventHandler(this.textprecio_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(251, 152);
            this.textnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(211, 26);
            this.textnombre.TabIndex = 30;
            this.textnombre.TextChanged += new System.EventHandler(this.textnombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 661);
            this.Controls.Add(this.dginstrumento);
            this.Controls.Add(this.Ascendnte);
            this.Controls.Add(this.Descendente);
            this.Controls.Add(this.color);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.textbuscar);
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
            this.Name = "Pila";
            this.Text = "Pila";
            ((System.ComponentModel.ISupportInitialize)(this.dginstrumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dginstrumento;
        private System.Windows.Forms.Button Ascendnte;
        private System.Windows.Forms.Button Descendente;
        private System.Windows.Forms.RadioButton color;
        private System.Windows.Forms.RadioButton Nombre;
        private System.Windows.Forms.RadioButton precio;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox textcolor;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}