using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergAplicacionContactos
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacto Eliminado");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacto Editado");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacto Agregado");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                //lblNumero.Text = "soy un numero";
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //lblNumero.Text = "otra cosa...";
            }
            }
        }
    }

