using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CATEDRA
{
    public partial class Form1 : Form
    {
        CLIENTECONTROLADOR db = new CLIENTECONTROLADOR();
        TabPage tabPageSave = null,tabPagePago=null;
        CLIENTEMODELO bdd= new CLIENTEMODELO();
        GRAFO grafo = new GRAFO();
        NODO entradaNorte = new NODO(new Point(280, 12), "EntradaNorte", "Ancla");
        NODO entradaSur = new NODO(new Point(280, 470), "EntradaSur", "Ancla");
        NODO AnclaCentro = new NODO(new Point(280, 230), "AnclaCentro", "Ancla");
        NODO AnclaDerecho = new NODO(new Point(590, 230), "AnclaDerecho", "Ancla");
        Boolean entryNorte = false, entrySur = false;
        ESTACIONAMIENTO EstacionamientoA = new ESTACIONAMIENTO('A', new Point(230, 150));
        ESTACIONAMIENTO EstacionamientoB = new ESTACIONAMIENTO('B', new Point(560, 150));
        ESTACIONAMIENTO EstacionamientoC = new ESTACIONAMIENTO('C', new Point(230, 420));
        ESTACIONAMIENTO EstacionamientoD = new ESTACIONAMIENTO('D', new Point(560, 420));

        public Form1()
        {
            InitializeComponent();
            txtDuiL.Text = Session.customer_DUI.ToString();
            txtContraL.Text = Session.customer_password.ToString();
            verificarPosicion();
            VerificarAPagar();
        }



        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        public void DibujarTodo(Graphics g)
        {
            db.cargarData(grafo, EstacionamientoA.entrada, g);
            db.cargarData(grafo, EstacionamientoB.entrada, g);
            db.cargarData(grafo, EstacionamientoD.entrada, g);
            db.cargarData(grafo, EstacionamientoC.entrada, g);

            grafo.Dibujar(g);
        }

        private void Pizzara_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush pincel = new SolidBrush(Color.Blue);
            Pen lapiz = new Pen(pincel);

            grafo.AgregarVertice(entradaNorte);
            grafo.AgregarVertice(entradaSur);
            grafo.AgregarVertice(AnclaCentro);
            grafo.AgregarVertice(AnclaDerecho);

            EstacionamientoA.Dibujar(g, pincel, lapiz, grafo);
            EstacionamientoB.Dibujar(g, pincel, lapiz, grafo);
            EstacionamientoC.Dibujar(g, pincel, lapiz, grafo);
            EstacionamientoD.Dibujar(g, pincel, lapiz, grafo);
            grafo.AgregarArco(entradaNorte.nombre, AnclaCentro.nombre, grafo.distanciaNodos(entradaNorte, AnclaCentro));
            grafo.AgregarArco(entradaSur.nombre, AnclaCentro.nombre, grafo.distanciaNodos(entradaSur, AnclaCentro));
            grafo.AgregarArco(AnclaCentro.nombre, AnclaDerecho.nombre, grafo.distanciaNodos(AnclaCentro, AnclaDerecho));
            grafo.AgregarArco(entradaNorte.nombre, EstacionamientoA.entrada.nombre, grafo.distanciaNodos(entradaNorte, EstacionamientoA.entrada));
            grafo.AgregarArco(AnclaDerecho.nombre, EstacionamientoB.entrada.nombre, grafo.distanciaNodos(AnclaDerecho, EstacionamientoB.entrada));
            grafo.AgregarArco(AnclaDerecho.nombre, EstacionamientoD.entrada.nombre, grafo.distanciaNodos(AnclaDerecho, EstacionamientoD.entrada));
            grafo.AgregarArco(entradaSur.nombre, EstacionamientoC.entrada.nombre, grafo.distanciaNodos(entradaSur, EstacionamientoC.entrada));


            db.cargarData(grafo, EstacionamientoA.entrada, g);
            db.cargarData(grafo, EstacionamientoB.entrada, g);
            db.cargarData(grafo, EstacionamientoD.entrada, g);
            db.cargarData(grafo, EstacionamientoC.entrada, g);

            grafo.Dibujar(g);
          

        }
        private void limpiarRutas(Graphics g, Brush pincel, Pen lapiz)
        {
            grafo.AgregarVertice(entradaNorte);
            grafo.AgregarVertice(entradaSur);
            grafo.AgregarVertice(AnclaCentro);
            grafo.AgregarVertice(AnclaDerecho);

            EstacionamientoA.Dibujar(g, pincel, lapiz, grafo);
            EstacionamientoB.Dibujar(g, pincel, lapiz, grafo);
            EstacionamientoC.Dibujar(g, pincel, lapiz, grafo);
            EstacionamientoD.Dibujar(g, pincel, lapiz, grafo);
            grafo.AgregarArco(entradaNorte.nombre, AnclaCentro.nombre, grafo.distanciaNodos(entradaNorte, AnclaCentro));
            grafo.AgregarArco(entradaSur.nombre, AnclaCentro.nombre, grafo.distanciaNodos(entradaSur, AnclaCentro));
            grafo.AgregarArco(AnclaCentro.nombre, AnclaDerecho.nombre, grafo.distanciaNodos(AnclaCentro, AnclaDerecho));
            grafo.AgregarArco(entradaNorte.nombre, EstacionamientoA.entrada.nombre, grafo.distanciaNodos(entradaNorte, EstacionamientoA.entrada));
            grafo.AgregarArco(AnclaDerecho.nombre, EstacionamientoB.entrada.nombre, grafo.distanciaNodos(AnclaDerecho, EstacionamientoB.entrada));
            grafo.AgregarArco(AnclaDerecho.nombre, EstacionamientoD.entrada.nombre, grafo.distanciaNodos(AnclaDerecho, EstacionamientoD.entrada));
            grafo.AgregarArco(entradaSur.nombre, EstacionamientoC.entrada.nombre, grafo.distanciaNodos(entradaSur, EstacionamientoC.entrada));


            db.cargarData(grafo, EstacionamientoA.entrada, g);
            db.cargarData(grafo, EstacionamientoB.entrada, g);
            db.cargarData(grafo, EstacionamientoD.entrada, g);
            db.cargarData(grafo, EstacionamientoC.entrada, g);

            grafo.Dibujar(g);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NODO entrada = null;
            if (rdbNorte.Checked || rdbSur.Checked)
            {
                if (rdbNorte.Checked)
                {
                    entrada = entradaNorte;
                }
                if (rdbSur.Checked)
                {
                    entrada = entradaSur;
                }
                string dui = txtDuiL.Text.Trim();
                string contrasena = txtContraL.Text.Trim().ToString();
                //  seleccionarEstacionamiento(entrada.nombre);
                db.Login(dui, contrasena, grafo, entrada, Pizzara.CreateGraphics());
                if (grafo.espacio != null)
                {
                    if (db.subirEspacio(grafo.cliente, grafo.espacio)) {
                        MessageBox.Show("El espacio otrogado es: " + grafo.espacio.nombre + "\n" + "La ruta a seguir es: \n" +
                            EstacionamientoA.nombre + "->" + grafo.espacio.nombre + "\n" + 
                           "Para mejor referencia guiarse del mapa en la parte posterior del sistema, una vez localizado dar aceptar para cerrar sesion");
                        verificarPosicion();
                        Session session = new Session();
                        Close();
                        Dashboard.ActiveForm.Hide();
                        var form2 = new Login();
                        form2.Show();

                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una entrada");
            }

        }

        public void seleccionarEstacionamiento(string entrada)
        {
            int valy;
            Brush pincel = new SolidBrush(Color.Blue);
            Pen lapiz = new Pen(pincel);
            Graphics g = Pizzara.CreateGraphics();
            grafo.estacio = null;
            grafo.espacio = null;
            //limpiarRutas(g, pincel, lapiz);
            switch (entrada)
            {
                case "EntradaNorte":
                    if (EstacionamientoA.espaciosDis >= 10)
                    {
                        valy = EstacionamientoA.entrada.posicion.Y - entradaNorte.posicion.Y;
                        db.recorrerEnEstacionamiento2(grafo, EstacionamientoA.entrada, g);
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), entradaNorte.posicion, new Point(entradaNorte.posicion.X, entradaNorte.posicion.Y + valy));
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(entradaNorte.posicion.X, entradaNorte.posicion.Y + valy), EstacionamientoA.entrada.posicion);
                        EstacionamientoA.espaciosDis--;
                        grafo.estacio = EstacionamientoA;
                    }
                    else if (EstacionamientoB.espaciosDis >= 10)
                    {
                        valy = EstacionamientoB.entrada.posicion.Y - entradaNorte.posicion.Y;
                        db.recorrerEnEstacionamiento2(grafo, EstacionamientoB.entrada, g);
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), entradaNorte.posicion, new Point(entradaNorte.posicion.X, entradaNorte.posicion.Y + valy));
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(entradaNorte.posicion.X, entradaNorte.posicion.Y + valy), EstacionamientoB.entrada.posicion);
                        EstacionamientoB.espaciosDis--;
                        grafo.estacio = EstacionamientoB;
                    }
                    break;
                case "EntradaSur":
                    if (EstacionamientoC.espaciosDis >= 10)
                    {
                        valy = EstacionamientoC.entrada.posicion.Y - entradaSur.posicion.Y;
                        db.recorrerEnEstacionamiento2(grafo, EstacionamientoC.entrada, g);
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), entradaSur.posicion, new Point(entradaSur.posicion.X, entradaSur.posicion.Y + valy));
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(entradaSur.posicion.X, entradaSur.posicion.Y + valy), EstacionamientoC.entrada.posicion);
                        EstacionamientoC.espaciosDis--;
                        grafo.estacio = EstacionamientoC;
                    }
                    else if (EstacionamientoD.espaciosDis >= 10)
                    {
                        valy = EstacionamientoD.entrada.posicion.Y - entradaSur.posicion.Y;
                        db.recorrerEnEstacionamiento2(grafo, EstacionamientoD.entrada, g);
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), entradaSur.posicion, new Point(entradaSur.posicion.X, entradaSur.posicion.Y + valy));
                        g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(entradaSur.posicion.X, entradaSur.posicion.Y + valy), EstacionamientoD.entrada.posicion);
                        EstacionamientoD.espaciosDis--;
                        grafo.estacio = EstacionamientoC;
                    }
                    break;
            }
        }

        private void rdbNorte_CheckedChanged(object sender, EventArgs e)
        {


            /* grafo.estacio = null;

             grafo.espacio = null;*/
            if (grafo != null)
            {
                db.ResetearEspacio(grafo);

            }
            //Pizzara.Refresh();

            entryNorte = true;
            seleccionarEstacionamiento("EntradaNorte");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rdbSur_CheckedChanged(object sender, EventArgs e)
        {
            /* grafo.estacio=null;
             grafo.espacio = null;*/
            if (grafo != null)
            {
                db.ResetearEspacio(grafo);

            }
            // Pizzara.Refresh();
            entrySur = true;

            seleccionarEstacionamiento("EntradaSur");

        }
        public void verificarPosicion()
        {
            if (bdd.verificarPosicion(Session.customer_DUI, Session.customer_password))
            {
                //MessageBox.Show("Usuario tiene posicion");
                txtAsignado.Text = Session.customerPosicion.ToString();
                tabPagePago = tabPrincipal.TabPages[2];
                tabPageSave = tabPrincipal.TabPages[0];
                tabPrincipal.TabPages.RemoveAt(0);
              


            }
            else
            {
                // MessageBox.Show("Usuario no tiene posicion");
                if (tabPageSave!=null)
                {
                    tabPrincipal.TabPages.Insert(0, tabPageSave);
                    tabPrincipal.TabPages.RemoveAt(2);

                }

            }
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            db.resetearEspacio(grafo, EstacionamientoA.entrada, Pizzara.CreateGraphics(), Session.customerPosicion) ;
            db.resetearEspacio(grafo, EstacionamientoC.entrada, Pizzara.CreateGraphics(), Session.customerPosicion);
            db.resetearEspacio(grafo, EstacionamientoB.entrada, Pizzara.CreateGraphics(), Session.customerPosicion);
            db.resetearEspacio(grafo, EstacionamientoD.entrada, Pizzara.CreateGraphics(), Session.customerPosicion);
            bdd.Pagar(Session.id_customer);
            MessageBox.Show("Muchas gracias por su visita! \n" +
                "Esperamos volver a verl@ \n " +
                "(Dar aceptar para cerrar sesion)");
            verificarPosicion();
            Session session = new Session();
            Close();
            Dashboard.ActiveForm.Hide();
            var form2 = new Login();
            form2.Show();

        }

        public void VerificarAPagar()
        {
            txtApagar.Text ="$"+bdd.CantidadAPagar(Session.id_customer).ToString();
            txtSalida.Text = bdd.horaSalida(Session.id_customer).ToString();
            txtEntrada.Text=bdd.horaEntrada(Session.id_customer).ToString();    
            

        }

    }
}
