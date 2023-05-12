using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATEDRA
{
    class CLIENTEMODELO
    {
        SqlConnection conexion;
        int i;
        public CLIENTEMODELO()
        {
            i = 0;
        }

        private SqlConnection ConectarDB()
        {
            try
            {
                conexion = new SqlConnection("Data Source=SOPORTE;Initial Catalog=PROYECTO;Integrated Security=True");
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        private void DesconectarDB()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void IngresarCliente(string nombre, string apellido, string dui, string contrasena)
        {
            try
            {
                SqlCommand da = new SqlCommand("Exec nuevo_cliente '" + nombre + "','" + apellido + "','" + dui + "','" + contrasena + "';" +
                "", ConectarDB());
                da.Prepare();
                if (da.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Ingreso correcto");
                }
                else
                {
                    MessageBox.Show("Error al crear Cliente");
                }
                DesconectarDB();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public bool Login(string DUI, string contrasena, GRAFO grafo)
        {
            CLIENTE clin = new CLIENTE();
            SqlDataReader read;
            SqlCommand da = new SqlCommand("Exec inicioSesion '"+DUI+"', '"+contrasena+"';", ConectarDB());
            read = da.ExecuteReader();
            if (read.Read())
            {
                clin.id = read.GetInt32(0);
                clin.Nombre = read["Nombre"].ToString();
                clin.Apellido = read["Apellido"].ToString();
                clin.DUI = read["Dui"].ToString();
                clin.pagar = Convert.ToInt32(read["pagar"].ToString());
                grafo.cliente = clin;
                DesconectarDB();
                return true;
            }
            else
            {
                DesconectarDB();
                return false;
            }            
        }

        public bool asignarPos(string posicion, int id)
        {
            SqlCommand da = new SqlCommand("Exec otorgarEspacio '" + posicion + "', " + id + ";", ConectarDB()) ;
            da.Prepare();
            if (da.ExecuteNonQuery() != 0)
            {
                DesconectarDB();
                return true;
            }
            else
            {
                DesconectarDB();
                return false;
            }
            
        }

        public bool espaciosUsados(GRAFO grafo)
        {
            i = 0;
            SqlCommand da = new SqlCommand("Select Posicion From Registros",ConectarDB());
            SqlDataReader read;
            read = da.ExecuteReader();
            string aux;
            while (read.Read())
            {
                aux = read["Posicion"].ToString();
                grafo.data[i] = aux;
                i++;
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
