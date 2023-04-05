using Sistema_de_parqueo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_parqueo.Forms
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
            lblNombre.Text=Session.customer_name+" "+Session.customer_lastname;
            lblDUI.Text = Session.customer_DUI;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
