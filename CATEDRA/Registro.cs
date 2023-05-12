using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATEDRA.Clase.modelo
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            String nombre, apellido, dui, contraseña;
            dui=txtDui.Text;
            nombre=txtNombre.Text;
            apellido = txtApellido.Text;
            contraseña=txtContraseña.Text;
            CLIENTEMODELO db=new CLIENTEMODELO();

            Logins logins = new Logins();
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(contraseña))
            {
                if (logins.verificarDui(dui))
                {
                     db.IngresarCliente(nombre, apellido, dui, contraseña);
                    this.Hide();
                    var form2 = new Login();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Ingrese su dui de forma correcta\n" +
                           "Con este formato: 12345678-9 ");
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos requeridos");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
