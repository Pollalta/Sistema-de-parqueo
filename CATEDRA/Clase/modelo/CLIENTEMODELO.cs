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
                conexion = new SqlConnection("Data Source=DESKTOP-F8DEKTG;Initial Catalog=PROYECTO;Integrated Security=True");
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
                MessageBox.Show("Este Usuario ya existe , inice session");
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
        public void getCliente(string DUI, string contrasena)
        {
            Session session=new Session();
            SqlCommand da = new SqlCommand("SELECT Id_Registro,Nombre,Apellido,Dui,Contrasena,Posicion,horaIngreso from Registros WHERE Dui = @dui AND Contrasena = @contrasena", ConectarDB());
            da.Parameters.AddWithValue("@dui", DUI);
            da.Parameters.AddWithValue("@contrasena", contrasena);
            SqlDataReader reader= da.ExecuteReader();
            if (reader.Read())
            {
                session.IDcustomer = (int)reader["Id_Registro"];

                session.Customer_name = (string)reader["Nombre"];
                session.Customer_Lastname= (string)reader["Apellido"];
                session.Customer_DUI = (string)reader["Dui"];
                session.Customer_Password = (string)reader["Contrasena"];
                session.CustomerPosicion =Convert.ToString( reader["Posicion"]);
                session.Customer_HoraIngresp = Convert.ToString( reader["horaIngreso"]);



            }
            reader.Close();
            DesconectarDB();
        }
        public bool BuscarUsuarioEnRegistro(string DUI, string contrasena)
        {
            bool existeUsuario = false;

            SqlCommand da = new SqlCommand("SELECT COUNT(*) FROM Registros WHERE DUI = @dui AND Contrasena = @contrasena", ConectarDB());
            da.Parameters.AddWithValue("@dui", DUI);
            da.Parameters.AddWithValue("@contrasena", contrasena);


          
            int resultado = (int)da.ExecuteScalar();
            if (resultado>0)
            {
                existeUsuario = true;
            }

            DesconectarDB();

            return existeUsuario;
        }
        public bool verificarPosicion(string DUI, string contrasena)
        {
            bool existeUsuario = false;

            SqlCommand da = new SqlCommand("SELECT COUNT(Posicion) FROM Registros WHERE DUI = @dui AND Contrasena = @contrasena", ConectarDB());
            da.Parameters.AddWithValue("@dui", DUI);
            da.Parameters.AddWithValue("@contrasena", contrasena);



            int resultado = (int)da.ExecuteScalar();
            if (resultado > 0)
            {
                existeUsuario = true;
            }

            DesconectarDB();

            return existeUsuario;
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
        public int CantidadAPagar(int id)
        {
            int precio=0; 
            SqlDataReader read;
            SqlCommand da = new SqlCommand("Exec salida_cliente @id", ConectarDB());
            da.Parameters.AddWithValue("@id", id);
            read = da.ExecuteReader();
            if (read.Read())
            {
                precio = Convert.ToInt16( read[0]);
            }
            DesconectarDB();
            return precio;

        }
        public string horaEntrada(int id)
        {
            String hora = "";
            SqlDataReader read;
            SqlCommand da = new SqlCommand("select horaIngreso from Registros where Id_Registro= @id", ConectarDB());
            da.Parameters.AddWithValue("@id", id);
            read = da.ExecuteReader();
            if (read.Read())
            {
                hora = read[0].ToString();
            }
            DesconectarDB();
           
            return hora;
        }
        public string horaSalida(int id)
        {
            String hora = "";
            SqlDataReader read;
            SqlCommand da = new SqlCommand("select horaSalida from Registros where Id_Registro= @id", ConectarDB());
            da.Parameters.AddWithValue("@id", id);
            read = da.ExecuteReader();
            if (read.Read())
            {
                hora = read[0].ToString();
            }
            DesconectarDB();

            return hora;
        }
 
        public void Pagar(int id)
        {
            SqlCommand da = new SqlCommand("Update Registros Set Posicion = NULL, horaIngreso = NULL, horaSalida=NULL Where Id_Registro = @Id", ConectarDB());
            da.Parameters.AddWithValue("@id", id);
            da.ExecuteNonQuery();
            DesconectarDB();
        }
    }
}
