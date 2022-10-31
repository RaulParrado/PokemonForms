namespace Pokemon
{
    partial class frmPokemon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemon));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtPuntosVida = new System.Windows.Forms.TextBox();
            this.lblPuntosVida = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbInfoContacto = new System.Windows.Forms.GroupBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtPuntosDefensa = new System.Windows.Forms.TextBox();
            this.txtPuntosAtaque = new System.Windows.Forms.TextBox();
            this.lblPuntosDefensa = new System.Windows.Forms.Label();
            this.lblPuntosAtaque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbInfoContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 48);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(21, 83);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFechaCreacion.Size = new System.Drawing.Size(91, 15);
            this.lblFechaCreacion.TabIndex = 2;
            this.lblFechaCreacion.Text = ":Fecha Creación";
            this.lblFechaCreacion.Click += new System.EventHandler(this.lblFechaNacimiento_Click);
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(133, 77);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(145, 23);
            this.dtpFechaCreacion.TabIndex = 3;
            // 
            // txtPuntosVida
            // 
            this.txtPuntosVida.Location = new System.Drawing.Point(133, 111);
            this.txtPuntosVida.MaxLength = 9;
            this.txtPuntosVida.Name = "txtPuntosVida";
            this.txtPuntosVida.Size = new System.Drawing.Size(53, 23);
            this.txtPuntosVida.TabIndex = 5;
            this.txtPuntosVida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuntosVida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntos_KeyPress);
            // 
            // lblPuntosVida
            // 
            this.lblPuntosVida.AutoSize = true;
            this.lblPuntosVida.Location = new System.Drawing.Point(21, 114);
            this.lblPuntosVida.Name = "lblPuntosVida";
            this.lblPuntosVida.Size = new System.Drawing.Size(73, 15);
            this.lblPuntosVida.TabIndex = 4;
            this.lblPuntosVida.Text = "Puntos Vida:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(41, 309);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(804, 153);
            this.dgvListado.TabIndex = 6;
            this.dgvListado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellClick);
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvListado_RowStateChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(41, 271);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(122, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(217, 271);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(456, 271);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(546, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.Location = new System.Drawing.Point(133, 192);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(291, 55);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 195);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 23);
            this.txtId.TabIndex = 15;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // gbInfoContacto
            // 
            this.gbInfoContacto.Controls.Add(this.lbTipo);
            this.gbInfoContacto.Controls.Add(this.cbTipo);
            this.gbInfoContacto.Controls.Add(this.txtPuntosDefensa);
            this.gbInfoContacto.Controls.Add(this.txtPuntosAtaque);
            this.gbInfoContacto.Controls.Add(this.lblPuntosDefensa);
            this.gbInfoContacto.Controls.Add(this.lblPuntosAtaque);
            this.gbInfoContacto.Controls.Add(this.lblId);
            this.gbInfoContacto.Controls.Add(this.lblNombre);
            this.gbInfoContacto.Controls.Add(this.txtId);
            this.gbInfoContacto.Controls.Add(this.txtNombre);
            this.gbInfoContacto.Controls.Add(this.txtDescripcion);
            this.gbInfoContacto.Controls.Add(this.lblFechaCreacion);
            this.gbInfoContacto.Controls.Add(this.lblDescripcion);
            this.gbInfoContacto.Controls.Add(this.dtpFechaCreacion);
            this.gbInfoContacto.Controls.Add(this.txtPuntosVida);
            this.gbInfoContacto.Controls.Add(this.lblPuntosVida);
            this.gbInfoContacto.Location = new System.Drawing.Point(41, 12);
            this.gbInfoContacto.Name = "gbInfoContacto";
            this.gbInfoContacto.Size = new System.Drawing.Size(580, 253);
            this.gbInfoContacto.TabIndex = 17;
            this.gbInfoContacto.TabStop = false;
            this.gbInfoContacto.Text = "Contacto:";
            this.gbInfoContacto.Enter += new System.EventHandler(this.gbInfoContacto_Enter);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(22, 156);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(33, 15);
            this.lbTipo.TabIndex = 22;
            this.lbTipo.Text = "Tipo:";
            this.lbTipo.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Acero",
            "Agua",
            "Bicho",
            "Dragón",
            "Eléctrico",
            "Fantasma",
            "Fuego",
            "Hada",
            "Hielo",
            "Lucha",
            "Normal",
            "Planta",
            "Psíquico",
            "Roca",
            "Siniestro",
            "Tierra",
            "Veneno",
            "Volador",
            "???"});
            this.cbTipo.Location = new System.Drawing.Point(130, 153);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 23);
            this.cbTipo.TabIndex = 21;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPuntosDefensa
            // 
            this.txtPuntosDefensa.Location = new System.Drawing.Point(505, 111);
            this.txtPuntosDefensa.MaxLength = 9;
            this.txtPuntosDefensa.Name = "txtPuntosDefensa";
            this.txtPuntosDefensa.Size = new System.Drawing.Size(53, 23);
            this.txtPuntosDefensa.TabIndex = 20;
            this.txtPuntosDefensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuntosDefensa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntos_KeyPress);
            // 
            // txtPuntosAtaque
            // 
            this.txtPuntosAtaque.Location = new System.Drawing.Point(308, 111);
            this.txtPuntosAtaque.MaxLength = 9;
            this.txtPuntosAtaque.Name = "txtPuntosAtaque";
            this.txtPuntosAtaque.Size = new System.Drawing.Size(53, 23);
            this.txtPuntosAtaque.TabIndex = 19;
            this.txtPuntosAtaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuntosAtaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntos_KeyPress);
            // 
            // lblPuntosDefensa
            // 
            this.lblPuntosDefensa.AutoSize = true;
            this.lblPuntosDefensa.Location = new System.Drawing.Point(398, 114);
            this.lblPuntosDefensa.Name = "lblPuntosDefensa";
            this.lblPuntosDefensa.Size = new System.Drawing.Size(92, 15);
            this.lblPuntosDefensa.TabIndex = 18;
            this.lblPuntosDefensa.Text = "Puntos Defensa:";
            // 
            // lblPuntosAtaque
            // 
            this.lblPuntosAtaque.AutoSize = true;
            this.lblPuntosAtaque.Location = new System.Drawing.Point(214, 114);
            this.lblPuntosAtaque.Name = "lblPuntosAtaque";
            this.lblPuntosAtaque.Size = new System.Drawing.Size(88, 15);
            this.lblPuntosAtaque.TabIndex = 17;
            this.lblPuntosAtaque.Text = "Puntos Ataque:";
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 479);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.gbInfoContacto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPokemon";
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbInfoContacto.ResumeLayout(false);
            this.gbInfoContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblFechaCreacion;
        private DateTimePicker dtpFechaCreacion;
        private TextBox txtPuntosVida;
        private Label lblPuntosVida;
        private DataGridView dgvListado;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtId;
        private Label lblId;
        private GroupBox gbInfoContacto;
        private TextBox txtPuntosDefensa;
        private TextBox txtPuntosAtaque;
        private Label lblPuntosDefensa;
        private Label lblPuntosAtaque;
        private ComboBox cbTipo;
        private Label lbTipo;
    }
}