namespace pryDeganiSp2._1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            Load += frmMain_Load;
        }

        public string[,] matReserva = new string[4, 3];

        int indiceFila = 0;

        // Declaracion de variables constantes para los c�lculos
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;

        private void frmMain_Load(object sender, EventArgs e)
        {

            // cargar los items en el primer control combobox
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Tipo A");
            cmbTipo.Items.Add("Tipo B");

            // esta acci�n provoca el disparo del evento "SelectedIndexChanged"
            cmbTipo.SelectedIndex = 0;

            // se inicializa la cantidad de d�as en 1
            txtDias.Text = "1";

            // inicialzar los dem�s controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;

            // en los radiobuttons se asigna s�lo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";

            // cargar los items del combo de tarjetas
            cmbTarjeta.Items.Clear();
            cmbTarjeta.Items.Add("Card Red");
            cmbTarjeta.Items.Add("Card Green");
            cmbTarjeta.Items.Add("Card Blue");

            // deshabiliar el bot�n "Aceptar"
            btnAceptar.Enabled = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando ocurra el evento se debe actualizar el
            // contenido del combo de personas
            int I = 0;

            // limpiar los items de personas
            cmbPersonas.Items.Clear();

            // si es tipo de caba�a A ->> cargar los items del 1 al 4
            if (cmbTipo.SelectedIndex == 0) // o cmbTipo.SelectedItem == "Tipo A"
            {
                for (I = 1; I <= 4; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            else
            { // si es tipo de caba�a B ->> cargar los items del 1 al 8
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            // establecer como preseleccionado el item 0 del combo
            cmbPersonas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // se deshabilita el combo y no se muestra nada
            cmbTarjeta.Enabled = false;
            cmbTarjeta.SelectedIndex = -1;
        }

        private void radioButtonTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // se habilita el combo y se muestra el primer item
            cmbTarjeta.Enabled = true;
            cmbTarjeta.SelectedIndex = 0;
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el bot�n "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el bot�n "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el bot�n "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;

  
            //Bot�n de comando "Aceptar"
            
                matReserva[indiceFila, 0] = cmbTipo.Text;
                matReserva[indiceFila, 1] = cmbPersonas.Text;
                matReserva[indiceFila, 2] = txtDias.Text;

                indiceFila++;

                // obtener la cantidad de d�as ingresados
                Dias = int.Parse(txtDias.Text);


            // controlar el tipo de caba�a para determinar el precio base
            if (cmbTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }

            // sumar al precio base el importe extra por persona (US$ 1)
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cmbPersonas.Text));

            // controlar los adicionales por las opciones
            Opcionales = 0;

            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTelevisor.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }

            // determinar el total por la cantidad de d�as
            Total = (PrecioBase + Opcionales) * Dias;

            // controlar la forma de pago
            if (optTarjeta.Checked == true)
            {
                if (cmbTarjeta.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
                Total = Total + Recargo;
            }

            // mostrar el resultado
            MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            // inicialzar los controles de la interfaz

            cmbTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna s�lo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void cmbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
