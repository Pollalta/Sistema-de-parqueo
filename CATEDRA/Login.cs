using CATEDRA.Clase.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATEDRA
{
    public partial class Login : Form
    {
        CLIENTEMODELO db=new CLIENTEMODELO();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String dui, Contra;
            dui = textBox1.Text;
            Contra = txtContraseña.Text;
            if (db.BuscarUsuarioEnRegistro(dui,Contra))
            {
                db.getCliente(dui,Contra);
                //MessageBox.Show("existe"+Session.customer_name+" "+Session.customer_lastname +" "+Session.customer_DUI );
                this.Hide();
                var form2 = new Dashboard();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Error:\nUsuario no encontrado verifique sus credenciales o registrese");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Registro();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
