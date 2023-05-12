using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATEDRA
{
    internal class ARCO
    {
        public NODO destino;
        public int peso;
        public bool activo;

        public float grosorFlecha;
        public Color color;

        public ARCO(NODO destino, int peso)
        {
            this.destino = destino;
            this.peso = peso;
            this.grosorFlecha = 2;
            this.activo = false;
            this.color = Color.White;
        }
    }
}
