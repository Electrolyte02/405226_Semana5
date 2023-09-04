using _405226_Problema_1._6_.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _405226_Problema_1._6_.Dominio
{
    internal class DBHelper
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private string stringConexion = "Data Source=DESKTOP-BKGGIPD;Initial Catalog=405226_Problema1.6;Integrated Security=True";

        public DBHelper() 
        {
            conexion = new SqlConnection(stringConexion);
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public void cargarCombo(ComboBox combo, string sentencia)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            combo.DataSource = tabla;
            combo.ValueMember= tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = 0;
        }

        public void NumeracionCamiones(Label labelTexto)
        {
            string aux = labelTexto.Text;
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_PROXIMO_CAMION";
            SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            Desconectar();
            labelTexto.Text = aux + param.Value.ToString();
        }

        public bool ConfirmarCamion(Camion nCamion)
        {
            bool aux = true;
            //Creamos la transaccion como nula
            SqlTransaction transaccion = null;
            try
            {
                Conectar();
                //Abro la conexion y despues abro la transaccion bajo esa conexion!
                transaccion = conexion.BeginTransaction();
                //Al crear el comando le pasamos x parametro: el string del comando, la conexion y la transaccion
                SqlCommand comando = new SqlCommand("SP_INSERTAR_CAMION", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@proxCamion",SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.Parameters.AddWithValue("@patente",nCamion.Patente);
                comando.Parameters.AddWithValue("@pesoMax",nCamion.PesoMaximo);
                comando.Parameters.AddWithValue("@estadoCamion",nCamion.EstadoCamion);
                comando.ExecuteNonQuery();

                int nroCamion = (int)param.Value;

                foreach(Carga c in nCamion.ListaCargas)
                {
                    SqlCommand comandoCarga = new SqlCommand("SP_INSERTAR_CARGA",conexion,transaccion);
                    comandoCarga.CommandType = CommandType.StoredProcedure;
                    comandoCarga.Parameters.AddWithValue("@idCamion",nroCamion);
                    comandoCarga.Parameters.AddWithValue("@pesoCarga",c.Peso);
                    comandoCarga.Parameters.AddWithValue("@tipoCarga",c.TipoCarga);
                    comandoCarga.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }

        public DataTable ConsultarCamiones(string sentencia,List<Parametro> lstParam)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            foreach(Parametro p in lstParam)
            {
                comando.Parameters.AddWithValue(p.Nombre,p.Valor);
            }
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
    }
}
