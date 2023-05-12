using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CATEDRA
{
    class CLIENTECONTROLADOR
    {
        CLIENTEMODELO modelo = new CLIENTEMODELO();
        public CLIENTECONTROLADOR() { }

        public void IngresarCliente(string nombre, string apellido, string dui, string contrasena)
        {
            modelo.IngresarCliente(nombre, apellido, dui, contrasena);
        }

        public void Login(string DUI, string contrasena, GRAFO grafo, NODO entrada, Graphics g)
        {
            if (modelo.Login(DUI, contrasena, grafo))
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        public bool subirEspacio(CLIENTE cliente, NODO espacio)
        {
            if (cliente.id != 0)
            {
                if (cliente.posicion != "")
                {
                    if (modelo.asignarPos(espacio.nombre, cliente.id))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void recorrerEnEstacionamiento(GRAFO grafo, NODO origen, Graphics g)
        {
            int Valy, Valx;
            foreach (ARCO arco in origen.ListaAdyacencia)
            {
                if (grafo.espacio == null)
                {
                    MessageBox.Show("Visitado:" + arco.destino.Visitado.ToString() + "Nombre: " + arco.destino.nombre + "Estado:" + arco.destino.estado.ToString());

                    if (arco.destino.tipo == "Ancla")
                    {
                        recorrerEnEstacionamiento(grafo, arco.destino, g);
                    }
                    else
                    {
                        if (arco.destino.Visitado == false)
                        {
                            arco.destino.Visitado = true;
                            if (arco.destino.estado == true)
                            {
                                grafo.espacio = arco.destino;
                                arco.destino.estado = false;
                                Valx = arco.destino.posicion.X - origen.posicion.X;
                                Valy = arco.destino.posicion.Y - origen.posicion.Y;
                                if (arco.destino.posicion.Y < origen.posicion.Y)
                                {
                                    g.DrawLine(new Pen(new SolidBrush(Color.Red)), origen.posicion,
                                        new Point(origen.posicion.X + Valx, origen.posicion.Y));
                                    g.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(origen.posicion.X + Valx, origen.posicion.Y),
                                        arco.destino.posicion);
                                    arco.destino.DibujarNodo(g);
                                }
                                return;
                            }
                            else
                            {
                                if (arco.destino.estado == false)
                                {
                                    arco.destino.Visitado = true;
                                    recorrerEnEstacionamiento(grafo, origen, g);
                                }
                            }
                        }
                    }
                }
                else
                {
                    return;
                }  
            }
        }

        public void cargarData(GRAFO grafo, NODO origen, Graphics g)
        {
            if (modelo.espaciosUsados(grafo))
            {
                foreach(ARCO arco in origen.ListaAdyacencia)
                {
                    for (int i = grafo.data.Length - 1; i >= 0; i--)
                    {
                        if (arco.destino.nombre == grafo.data[i])
                        {
                            arco.destino.estado = false;
                        }
                    }
                }
            }
        }

    }
}
