using _405226_Problema_1._6_.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        public Camion TraerCamion(int idcamion)
        {
            Camion camion = new Camion();
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_CAMION";
            Parametro param = new Parametro("@id_camion", idcamion);
            comando.Parameters.AddWithValue(param.Nombre,param.Valor);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            foreach(DataRow fila in tabla.Rows)
            {
                camion.IdCamion = Convert.ToInt32(fila["id_camion"].ToString());
                camion.Patente = fila["patente"].ToString();
                camion.EstadoCamion = Convert.ToInt32(fila["estado_camion"].ToString());
                camion.PesoMaximo = Convert.ToInt32(fila["peso_maximo"].ToString());
            }
            return camion;
        }

        public Camion TraerCargas(Camion camionACargar)
        {
            Parametro param = new Parametro("@id_camion",camionACargar.IdCamion);
            Conectar();
            comando.CommandText = "SP_CONSULTAR_CARGAS_CAMION";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            foreach (DataRow r in tabla.Rows)
            {
                Carga nCarga = new Carga();
                nCarga.IdCarga = Convert.ToInt32(r["id_carga"].ToString());
                nCarga.Peso = Convert.ToDouble(r["peso"].ToString());
                nCarga.TipoCarga = Convert.ToInt32(r["tipo_carga"].ToString());
                camionACargar.AgregarCarga(nCarga);
            }
            Desconectar();
            return camionACargar;
        }

        public bool ActualizarCamion(Camion camion)
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
                SqlCommand comando2 = new SqlCommand("SP_BORRAR_CARGAS",conexion,transaccion);
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_CAMION", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@patente", camion.Patente);
                comando.Parameters.AddWithValue("@id_camion",camion.IdCamion);
                comando.Parameters.AddWithValue("@estado_camion", camion.EstadoCamion);
                comando.Parameters.AddWithValue("@peso_maximo", camion.PesoMaximo);
                comando.ExecuteNonQuery();
                comando2.CommandType = CommandType.StoredProcedure;
                comando2.Parameters.AddWithValue("@id_camion",camion.IdCamion);
                comando2.ExecuteNonQuery();
                foreach (Carga c in camion.ListaCargas)
                {
                    SqlCommand comandoCarga = new SqlCommand("SP_INSERTAR_CARGA", conexion, transaccion);
                    comandoCarga.CommandType = CommandType.StoredProcedure;
                    comandoCarga.Parameters.AddWithValue("@idCamion",camion.IdCamion);
                    comandoCarga.Parameters.AddWithValue("@pesoCarga", c.Peso);
                    comandoCarga.Parameters.AddWithValue("@tipoCarga", c.TipoCarga);
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
                    Desconectar();
                }
            }
            return aux;
        }

        public int BorrarCamion(int nroCamion)
        {
            int aux = 0;
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_BORRAR_CAMION";
            Parametro param = new Parametro("@id_camion", nroCamion);
            comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            aux = comando.ExecuteNonQuery();
            Desconectar();
            return aux;
        }

        public bool PruebaUpdate(Camion camion)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            Conectar();
            transaccion = conexion.BeginTransaction();
            SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_CAMION", conexion,transaccion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@patente", camion.Patente);
            comando.Parameters.AddWithValue("@id_camion", camion.IdCamion);
            comando.Parameters.AddWithValue("@estado_camion", camion.EstadoCamion);
            comando.Parameters.AddWithValue("@peso_maximo", camion.PesoMaximo);
            comando.ExecuteNonQuery();
            Desconectar();
            return aux;
        }
    }
}
