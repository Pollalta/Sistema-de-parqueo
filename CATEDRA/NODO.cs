using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CATEDRA
{
    class NODO
    {
        public string nombre;
        public List<ARCO> ListaAdyacencia;
        public bool estado;
        public Color color_nodo;
        public Point posicion;
        public bool Visitado;
        public NODO Padre;
        public string tipo;

        public NODO(Point posicion, string nombre, string tipo)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.color_nodo = Color.Aqua;
            this.estado = true;
            this.ListaAdyacencia = new List<ARCO>();
            this.Visitado = false;
            this.tipo = tipo;
        }

        public NODO(string nombre)
        {
            this.nombre = nombre;
            this.color_nodo = Color.Aqua;
            this.estado = false;
            this.ListaAdyacencia = new List<ARCO>();
            this.Visitado = false;
            this.Padre = null;
        }

        public NODO(Point P, Point Q, string Nombre)
        {
            int valx, valy;
            valx = Q.X - P.X;
            valy = Q.Y - P.Y;
            this.posicion.X = P.X + valx;
            this.posicion.Y = Q.Y - valy;
            nombre = Nombre;
            estado = false;
            this.ListaAdyacencia = new List<ARCO>();
            this.Visitado = false;
            this.Padre = null;
        }

        public void DibujarNodo(Graphics g)
        {
            if (!(tipo == "Ancla"))
            {
                if (estado == true)
                {
                    Brush pincel = new SolidBrush(Color.DarkGreen);
                    Pen lapiz = new Pen(pincel);
                    g.DrawEllipse(lapiz, new Rectangle(posicion.X - 5, posicion.Y, 10, 10));
                    g.FillEllipse(pincel, new Rectangle(posicion.X - 5, posicion.Y, 10, 10));
                }
                else
                {
                    Brush pincel = new SolidBrush(Color.Red);
                    Pen lapiz = new Pen(pincel);
                    g.DrawEllipse(lapiz, new Rectangle(posicion.X - 5, posicion.Y, 10, 10));
                    g.FillEllipse(pincel, new Rectangle(posicion.X - 5, posicion.Y, 10, 10));
                }
            }
            
        }
        public void DibujarAncla(Graphics g)
        {

            if (estado == false)
            {
                Brush pincel = new SolidBrush(Color.Blue);
                Pen lapiz = new Pen(pincel);
                g.DrawEllipse(lapiz, new Rectangle(posicion.X - 5, posicion.Y, 10, 10));
                g.FillEllipse(pincel, new Rectangle(posicion.X - 5, posicion.Y, 10, 10));
            }
        }

        public void DibujarArco(Graphics g)
        {
            float distancia;
            int difY, difX;
            foreach (ARCO arco in ListaAdyacencia)
            {
                difX = this.posicion.X - arco.destino.posicion.X;
                difY = this.posicion.Y - arco.destino.posicion.Y;

                distancia = (float)Math.Sqrt((difX * difX) + (difY * difY));

                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4,4,true);
                bigArrow.BaseCap = LineCap.Triangle;

                if (arco.activo)
                {
                    arco.color = Color.Red;
                }
                else
                {
                    arco.color = Color.White;
                }

                g.DrawLine(new Pen( new SolidBrush(arco.color), arco.grosorFlecha)
                {
                    CustomEndCap = bigArrow,
                    Alignment = PenAlignment.Center
                },
                posicion, new Point(arco.destino.posicion.X + (int)( difX / distancia),
                arco.destino.posicion.Y + (int)(difY /distancia)
                )
                );

            }
        }




    }
}
