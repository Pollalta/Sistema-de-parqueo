using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATEDRA
{
    internal class ESTACIONAMIENTO
    {
        public char nombre;
        public Point origen;
        public int espaciosDis;
        public NODO entrada;

        public ESTACIONAMIENTO(char nombre, Point origen, int espaciosDis, NODO entrada)
        {
            this.entrada = entrada;
            this.nombre = nombre;
            this.origen = origen;
            this.espaciosDis = espaciosDis;
        }

        public ESTACIONAMIENTO(char nombre, Point posicion)
        {
            this.nombre = nombre;
            this.origen = posicion;
            this.espaciosDis = 20;
        }

        public void Dibujar(Graphics g, Brush pincel, Pen lapiz, GRAFO grafo)
        {
            //Contorno del estacionamiento
            Point[] puntos = new Point[5];
            puntos[0] = new Point(origen.X, origen.Y);
            puntos[1] = new Point(origen.X, origen.Y - 130);
            puntos[2] = new Point(origen.X - 220, origen.Y - 130);
            puntos[3] = new Point(origen.X - 220, origen.Y + 50);
            puntos[4] = new Point(origen.X - 30, origen.Y + 50);
            g.DrawLines(lapiz, puntos);

            NODO Ancla1 = new NODO(new Point(origen.X - 20, origen.Y + 22), nombre + "Ancla1", "Ancla");
            Ancla1.estado = true;

            entrada = Ancla1;
            NODO Ancla2 = new NODO(new Point(origen.X - 205, origen.Y + 22), nombre + "Ancla2", "Ancla");
            Ancla2.estado = true;

            NODO Ancla3 = new NODO(new Point(origen.X - 205, origen.Y - 50), nombre + "Ancla3", "Ancla");
            Ancla3.estado = true;

            NODO Ancla4 = new NODO(new Point(origen.X - 205, origen.Y - 120), nombre + "Ancla4", "Ancla");
            Ancla4.estado = true;

            Rectangle[] rectangulos = new Rectangle[14];
            // Estacionamientos de abajo
            rectangulos[0] = new Rectangle(origen.X - 40, origen.Y - 30, 1, 40);
            rectangulos[1] = new Rectangle(origen.X - 70, origen.Y - 30, 1, 40);
            rectangulos[2] = new Rectangle(origen.X - 100, origen.Y - 30, 1, 40);
            rectangulos[3] = new Rectangle(origen.X - 130, origen.Y - 30, 1, 40);
            rectangulos[4] = new Rectangle(origen.X - 160, origen.Y - 30, 1, 40);
            rectangulos[5] = new Rectangle(origen.X - 190, origen.Y - 30, 1, 40);
            rectangulos[6] = new Rectangle(origen.X - 190, (origen.Y - 30) + 20, 150, 1);
            //puntos estacionamiento abajo linea de abajo
            NODO Espacio1 = new NODO(new Point(origen.X - ((40 + 70) / 2), origen.Y - 4),  nombre + "1", "Espacio");
            NODO Espacio2 = new NODO(new Point(origen.X - ((70 + 100) / 2), origen.Y - 4), nombre + "2", "Espacio");
            NODO Espacio3 = new NODO(new Point(origen.X - ((100 + 130) / 2), origen.Y - 4), nombre + "3", "Espacio");
            NODO Espacio4 = new NODO(new Point(origen.X - ((130 + 160) / 2), origen.Y - 4), nombre + "4", "Espacio");
            NODO Espacio5 = new NODO(new Point(origen.X - ((160 + 190) / 2), origen.Y - 4), nombre + "5", "Espacio");

            //puntos estacionamiento abajo linea de arriba
            NODO Espacio6 = new NODO(new Point(origen.X - ((40 + 70) / 2), origen.Y - 25), nombre + "6", "Espacio");
            NODO Espacio7 = new NODO(new Point(origen.X - ((70 + 100) / 2), origen.Y - 25), nombre + "7", "Espacio");
            NODO Espacio8 = new NODO(new Point(origen.X - ((100 + 130) / 2), origen.Y - 25), nombre + "8", "Espacio");
            NODO Espacio9 = new NODO(new Point(origen.X - ((130 + 160) / 2), origen.Y - 25), nombre + "9", "Espacio");
            NODO Espacio10 = new NODO(new Point(origen.X - ((160 + 190) / 2), origen.Y - 25), nombre + "10", "Espacio");

            //Estacionamiento arriba
            rectangulos[7] = new Rectangle(origen.X - 40, origen.Y - 100, 1, 40);
            rectangulos[8] = new Rectangle(origen.X - 70, origen.Y - 100, 1, 40);
            rectangulos[9] = new Rectangle(origen.X - 100, origen.Y - 100, 1, 40);
            rectangulos[10] = new Rectangle(origen.X - 130, origen.Y - 100, 1, 40);
            rectangulos[11] = new Rectangle(origen.X - 160, origen.Y - 100, 1, 40);
            rectangulos[12] = new Rectangle(origen.X - 190, origen.Y - 100, 1, 40);
            rectangulos[13] = new Rectangle(origen.X - 190, (origen.Y - 100) + 20, 150, 1);
            g.DrawRectangles(lapiz, rectangulos);

            NODO Espacio11 = new NODO(new Point(origen.X - ((40 + 70) / 2), origen.Y - 75), nombre + "11", "Espacio");
            NODO Espacio12 = new NODO(new Point(origen.X - ((70 + 100) / 2), origen.Y - 75), nombre + "12", "Espacio");
            NODO Espacio13 = new NODO(new Point(origen.X - ((100 + 130) / 2), origen.Y - 75), nombre + "13", "Espacio");
            NODO Espacio14 = new NODO(new Point(origen.X - ((130 + 160) / 2), origen.Y - 75), nombre + "14", "Espacio");
            NODO Espacio15 = new NODO(new Point(origen.X - ((160 + 190) / 2), origen.Y - 75), nombre + "15", "Espacio");

            NODO Espacio16 = new NODO(new Point(origen.X - ((40 + 70) / 2), origen.Y - 95), nombre + "16", "Espacio");
            NODO Espacio17 = new NODO(new Point(origen.X - ((70 + 100) / 2), origen.Y - 95), nombre + "17", "Espacio");
            NODO Espacio18 = new NODO(new Point(origen.X - ((100 + 130) / 2), origen.Y - 95), nombre + "18", "Espacio");
            NODO Espacio19 = new NODO(new Point(origen.X - ((130 + 160) / 2), origen.Y - 95), nombre + "19", "Espacio");
            NODO Espacio20 = new NODO(new Point(origen.X - ((160 + 190) / 2), origen.Y - 95), nombre + "20", "Espacio");



            

            grafo.AgregarVertice(Ancla1);
            grafo.AgregarVertice(Ancla2);
            grafo.AgregarVertice(Ancla3);
            grafo.AgregarVertice(Ancla4);

            grafo.AgregarVertice(Espacio1);
            grafo.AgregarVertice(Espacio2);
            grafo.AgregarVertice(Espacio3);
            grafo.AgregarVertice(Espacio4);
            grafo.AgregarVertice(Espacio4);
            grafo.AgregarVertice(Espacio5);
            grafo.AgregarVertice(Espacio6);
            grafo.AgregarVertice(Espacio7);
            grafo.AgregarVertice(Espacio8);
            grafo.AgregarVertice(Espacio9);
            grafo.AgregarVertice(Espacio10);
            grafo.AgregarVertice(Espacio11);
            grafo.AgregarVertice(Espacio12);
            grafo.AgregarVertice(Espacio13);
            grafo.AgregarVertice(Espacio14);
            grafo.AgregarVertice(Espacio15);
            grafo.AgregarVertice(Espacio16);
            grafo.AgregarVertice(Espacio17);
            grafo.AgregarVertice(Espacio18);
            grafo.AgregarVertice(Espacio19);
            grafo.AgregarVertice(Espacio20);

            
            grafo.AgregarArco(Ancla1.nombre, Espacio1.nombre, grafo.distanciaNodos(Ancla1, Espacio1));
            grafo.AgregarArco(Ancla1.nombre, Espacio2.nombre, grafo.distanciaNodos(Ancla1, Espacio2));
            grafo.AgregarArco(Ancla1.nombre, Espacio3.nombre, grafo.distanciaNodos(Ancla1, Espacio3));
            grafo.AgregarArco(Ancla1.nombre, Espacio4.nombre, grafo.distanciaNodos(Ancla1, Espacio4));
            grafo.AgregarArco(Ancla1.nombre, Espacio5.nombre, grafo.distanciaNodos(Ancla1, Espacio5));
            grafo.AgregarArco(Ancla1.nombre, Ancla2.nombre, grafo.distanciaNodos(Ancla1, Ancla2));


            grafo.AgregarArco(Ancla2.nombre, Ancla3.nombre, grafo.distanciaNodos(Ancla2, Ancla3));

           
            grafo.AgregarArco(Ancla3.nombre, Espacio6.nombre, grafo.distanciaNodos(Ancla3, Espacio6));
            grafo.AgregarArco(Ancla3.nombre, Espacio7.nombre, grafo.distanciaNodos(Ancla3, Espacio7));
            grafo.AgregarArco(Ancla3.nombre, Espacio8.nombre, grafo.distanciaNodos(Ancla3, Espacio8));
            grafo.AgregarArco(Ancla3.nombre, Espacio9.nombre, grafo.distanciaNodos(Ancla3, Espacio9));
            grafo.AgregarArco(Ancla3.nombre, Espacio10.nombre, grafo.distanciaNodos(Ancla3, Espacio10));
            grafo.AgregarArco(Ancla3.nombre, Espacio11.nombre, grafo.distanciaNodos(Ancla3, Espacio11));
            grafo.AgregarArco(Ancla3.nombre, Espacio12.nombre, grafo.distanciaNodos(Ancla3, Espacio12));
            grafo.AgregarArco(Ancla3.nombre, Espacio13.nombre, grafo.distanciaNodos(Ancla3, Espacio13));
            grafo.AgregarArco(Ancla3.nombre, Espacio14.nombre, grafo.distanciaNodos(Ancla3, Espacio14));
            grafo.AgregarArco(Ancla3.nombre, Espacio15.nombre, grafo.distanciaNodos(Ancla3, Espacio15));

            grafo.AgregarArco(Ancla3.nombre, Ancla4.nombre, grafo.distanciaNodos(Ancla3, Ancla4));
            grafo.AgregarArco(Ancla4.nombre, Espacio16.nombre, grafo.distanciaNodos(Ancla4, Espacio16));
            grafo.AgregarArco(Ancla4.nombre, Espacio17.nombre, grafo.distanciaNodos(Ancla4, Espacio17));
            grafo.AgregarArco(Ancla4.nombre, Espacio18.nombre, grafo.distanciaNodos(Ancla4, Espacio18));
            grafo.AgregarArco(Ancla4.nombre, Espacio19.nombre, grafo.distanciaNodos(Ancla4, Espacio19));
            grafo.AgregarArco(Ancla4.nombre, Espacio20.nombre, grafo.distanciaNodos(Ancla4, Espacio20));
        }


    }
}
