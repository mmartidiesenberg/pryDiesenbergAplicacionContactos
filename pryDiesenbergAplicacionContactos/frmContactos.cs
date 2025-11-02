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
        int Indice = 0;

        struct Contacto
        {
            public string Nombre;
            public string Apellido;
            public string Numero;
            public string Correo;
            public string Categoria;
        }
        Contacto[] vecContactos = new Contacto[100];
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacto Eliminado Exitosamente");    
        }

      


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || mskNumero.Text == "" || txtCorreo.Text == "" || lstCategoría.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
               
            else
            {
                vecContactos[Indice].Nombre = txtNombre.Text;
                vecContactos[Indice].Apellido = txtApellido.Text;
                vecContactos[Indice].Numero = mskNumero.Text;
                vecContactos[Indice].Correo = txtCorreo.Text;
                vecContactos[Indice].Categoria = lstCategoría.Text;
                Indice++;
                MessageBox.Show("Contacto Agregado Exitosamente");
            }
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

        private void frmContactos_Load(object sender, EventArgs e)
        {

        }
    }
    }

