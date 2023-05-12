using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATEDRA
{
    class CLIENTE
    {
        public int id;
        public string Nombre;
        public string Apellido;
        public string DUI;
        public string posicion;
        public DateTime horaIngreso;
        public DateTime horaSalida;
        public int pagar;
        public double monto;

        public CLIENTE()
        {
            
        }


        public CLIENTE(int id, string nombre, string apellido, string dui, string posicion, DateTime horaIngreso, DateTime horaSalida, int pagar, double monto)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;   
            this.DUI = dui;
            this.posicion = posicion;
            this.horaIngreso = horaIngreso;
            this.horaSalida = horaSalida;
            this.monto = monto;
            this.pagar = pagar;
        }

        public void resetCliente()
        {
            this.id = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.DUI = "";
            this.posicion = "";
            this.horaIngreso = new DateTime();
            this.horaSalida = new DateTime();
            this.monto = 0;
            this.pagar = 0;
        }

    }
}
