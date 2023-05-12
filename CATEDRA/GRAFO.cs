using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATEDRA
{
    internal class GRAFO
    {
        public List<NODO> nodos;
        public NODO espacio;
        public CLIENTE cliente;
        public ESTACIONAMIENTO estacio;
        public string[] data;
        public GRAFO()
        {
            nodos = new List<NODO>();
            espacio = null;
            cliente = new CLIENTE();
            data = new string[80];
        }

        public NODO AgregarVertice(string nombre)
        {
            NODO nodo = new NODO(nombre);
            nodos.Add(nodo);
            return nodo;
        }

        public void AgregarVertice(NODO nuevoNodo)
        {
            nodos.Add(nuevoNodo);
        }

        public bool AgregarArco(string origen, string destino, int peso)
        {
            NODO Origen, Destino;
            if ((Origen = nodos.Find(v => v.nombre == origen)) == null)
            {
                throw new Exception("El nodo" +  origen + "no existe dentro del grafo");
            }
            if ((Destino = nodos.Find(v => v.nombre == destino)) == null)
            {
                throw new Exception("El nodo" + destino + "no existe dentro del grafo");
            }
            return AgregarArco(Origen, Destino, peso);
        }

        public bool AgregarArco(NODO origen, NODO destino, int peso)
        {
            if (origen.ListaAdyacencia.Find(v => v.destino == destino) == null)
            {
                origen.ListaAdyacencia.Add(new ARCO(destino, peso));
                return true;
            }
            return false;
        }

        public int distanciaNodos(NODO origen, NODO destino)
        {
            int peso;
            peso = (int)Math.Round(Math.Sqrt(Math.Pow(destino.posicion.X - origen.posicion.X, 2) + Math.Pow(destino.posicion.Y - origen.posicion.Y, 2)));
            return peso;
        }

        public void Dibujar(Graphics g)
        {
            foreach (NODO nodo in nodos)
            {
                nodo.DibujarNodo(g);
            }

        }

        public void ordenarnodos(NODO origen)
        {
            foreach(ARCO arco in origen.ListaAdyacencia)
            {

            }
        }

    }
}
