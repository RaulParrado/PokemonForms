using System.Data;
using System.Diagnostics.Contracts;

namespace Pokemon
{
    public partial class frmPokemon : Form
    {
        public frmPokemon()
        {
            InitializeComponent();
        }

        #region Enumerado

        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        #region Eventos

        /// <summary>
        /// Evento Load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();

        }

        /// <summary>
        /// Evento KeyPress para controlar que no se puedan escribir caracteres en el tel�fono.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void txtPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento del bot�n a�adir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnA�adir_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento del bot�n eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea eliminar el pokemon?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Pokemon p = ObtenerInformacion();
                correcto = Repo.EliminarPokemon(p);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }

        }

        /// <summary>
        /// Evento del bot�n Modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento click del bot�n guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la informaci�n
                Pokemon p = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repo.CrearPokemon(p);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repo.ModificarPokemon(p);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Nombre, fecha, puntos y tipo son obligatorios.");
            }

        }

        /// <summary>
        /// Evento click del bot�n Cancelar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea salir de la edici�n?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (dgvListado.SelectedRows.Count == 1)
                {
                    // Recargamos su informaci�n en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvListado.SelectedRows[0]);
                }
            }
        }

        /// <summary>
        /// Evento click de la celda.
        /// Cuando se hace click en una celda se selecciona la fila entera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListado.Rows[e.RowIndex].Selected = true;
        }

        /// <summary>
        /// Evento para cuando una fila cambia de estado en el grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListado_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operaci�n que no sea que ha cambiado la selecci�n de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);

        }

        #endregion

        #region M�todos

        /// <summary>
        /// M�todo para establecer el modo de la pantalla a edici�n.
        /// </summary>
        public void ModoPantallaEdicion()
        {
            // Limpiamos s�lo si es modo creaci�n, si es modo edici�n dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                txtNombre.Text = "";
                dtpFechaCreacion.Value = DateTime.Now;//porque para crearlo se supone que lo creas con la fecha de hoy
                txtPuntosVida.Text = "";
                txtPuntosAtaque.Text = "";
                txtPuntosDefensa.Text = "";
                cbTipo.Text = "";
                txtDescripcion.Text = "";
                txtId.Text = "";

            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            dtpFechaCreacion.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPuntosVida.Enabled = true;
            txtPuntosAtaque.Enabled = true;
            txtPuntosDefensa.Enabled = true;
            cbTipo.Enabled = true;

            txtId.Enabled = false;

            btnA�adir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            dgvListado.Enabled = false;
        }

        /// <summary>
        /// M�todo para establecer el modo de la pantalla a lectura.
        /// </summary>
        public void ModoPantallaLectura()
        {
            txtNombre.Text = "";
            dtpFechaCreacion.Value = DateTime.Now;
            txtPuntosVida.Text = "";
            txtPuntosAtaque.Text = "";
            txtPuntosDefensa.Text = "";
            cbTipo.Text = "";
            txtDescripcion.Text = "";
            txtId.Text = "";

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnA�adir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            txtNombre.Enabled = false;
            dtpFechaCreacion.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPuntosVida.Enabled = false;
            txtPuntosAtaque.Enabled = false;
            txtPuntosDefensa.Enabled = false;
            cbTipo.Enabled = false;
            txtId.Enabled = false;

            dgvListado.Enabled = true;
        }

        /// <summary>
        /// M�todo para obtener la informaci�n del formulario.
        /// </summary>
        /// <returns>Contacto con la informaci�n del formulario.</returns>
        public Pokemon ObtenerInformacion()
        {
            Pokemon p = new Pokemon();

            p.nombre = txtNombre.Text;
            p.fechaCreacion = dtpFechaCreacion.Value;
            p.puntosVida = Convert.ToInt32(txtPuntosVida.Text);
            p.puntosAtaque = Convert.ToInt32(txtPuntosAtaque.Text);
            p.puntosDefensa = Convert.ToInt32(txtPuntosDefensa.Text);
            p.tipo = cbTipo.Text;
            p.descripcion = txtDescripcion.Text;

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                p.Id = Convert.ToInt32(txtId.Text);
            }

            return p;
        }

        /// <summary>
        /// M�todo que carga y configura el grid.
        /// </summary>
        /// <param name="Pokemons">DataTable con la info de los pokemons</param>
        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repo.ObtenerPokemons();
            dgvListado.DataSource = ds.Tables[0];

            // Tama�os columnas
            dgvListado.Columns["Id"].Width = 40;
            dgvListado.Columns["Nombre"].Width = 150;
            dgvListado.Columns["FechaCreacion"].Width = 150;
            dgvListado.Columns["PuntosVida"].Width = 80;
            dgvListado.Columns["PuntosAtaque"].Width = 80;
            dgvListado.Columns["PuntosDefensa"].Width = 80;
            dgvListado.Columns["Tipo"].Width = 100;
            dgvListado.Columns["Descripcion"].Width = 300;

            // Renombrado columnas
            dgvListado.Columns["FechaCreacion"].HeaderText = "Fecha Creacion";
            dgvListado.Columns["PuntosVida"].HeaderText = "Puntos Vida";
            dgvListado.Columns["PuntosAtaque"].HeaderText = "Puntos Ataque";
            dgvListado.Columns["PuntosDefensa"].HeaderText = "Puntos Defensa";


            // Formato fecha en espa�ol
            dgvListado.Columns["FechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        /// <summary>
        /// M�todo que selecciona la primera fila del grid si existe.
        /// </summary>
        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// M�todo que carga la informaci�n de la fila seleccionada en los controles.
        /// </summary>
        /// <param name="filaSeleccionada"></param>
        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dtpFechaCreacion.Value = (DateTime)filaSeleccionada.Cells["FechaCreacion"].Value;
            txtPuntosVida.Text = filaSeleccionada.Cells["PuntosVida"].Value.ToString();
            txtPuntosAtaque.Text = filaSeleccionada.Cells["PuntosAtaque"].Value.ToString();
            txtPuntosDefensa.Text = filaSeleccionada.Cells["PuntosDefensa"].Value.ToString();
            cbTipo.Text = filaSeleccionada.Cells["Tipo"].Value.ToString();

            txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();

        }

        /// <summary>
        /// Funci�n que nos indica si la informaci�n obligatoria est� cumplimentada o no.
        /// </summary>
        /// <returns></returns>
        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtPuntosVida.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void gbInfoContacto_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}