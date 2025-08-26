namespace pryMendezEjercicio1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmBienvenida frmBienvenida = new frmBienvenida();
            frmBienvenida.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // le digo a la caja de texto que asigne nada
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            //borra los elementos de la lista
            //cmbModulo.Items.Clear();
            ComboBoxModulo.SelectedIndex = -1;

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {

                txtContraseña.Enabled = false;
                //para asignar o grabar datos =
                // comparar valores ==

            }
            else
            {
                txtContraseña.Enabled = true;
            }



        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                ComboBoxModulo.Enabled = true;

            }
            else
            {
                ComboBoxModulo.Enabled = false;
                ComboBoxModulo.SelectedIndex = -1;
            }
        }

        private void ComboBoxModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxModulo.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
