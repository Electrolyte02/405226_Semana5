using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _405226_Problema_1._6_.Datos.Interfaz;
using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _405226_Problema_1._6_.Datos.Implementacion
{
    internal class CamionesDAO : ICamionesDAO
    {
        public bool ActualizarCamion(Camion oCamion)
        {
            bool aux = true;
            //Creamos la transaccion como nula
            SqlTransaction transaccion = null;
            SqlConnection conexion = Dominio.Servicio.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                //Abro la conexion y despues abro la transaccion bajo esa conexion!
                transaccion = conexion.BeginTransaction();
                //Al crear el comando le pasamos x parametro: el string del comando, la conexion y la transaccion
                SqlCommand comando2 = new SqlCommand("SP_BORRAR_CARGAS", conexion, transaccion);
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_CAMION", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@patente", oCamion.Patente);
                comando.Parameters.AddWithValue("@id_camion", oCamion.IdCamion);
                comando.Parameters.AddWithValue("@estado_camion", oCamion.EstadoCamion.IdEstado);
                comando.Parameters.AddWithValue("@peso_maximo", oCamion.PesoMaximo);
                comando.ExecuteNonQuery();
                comando2.CommandType = CommandType.StoredProcedure;
                comando2.Parameters.AddWithValue("@id_camion", oCamion.IdCamion);
                comando2.ExecuteNonQuery();
                foreach (Carga c in oCamion.ListaCargas)
                {
                    SqlCommand comandoCarga = new SqlCommand("SP_INSERTAR_CARGA", conexion, transaccion);
                    comandoCarga.CommandType = CommandType.StoredProcedure;
                    comandoCarga.Parameters.AddWithValue("@idCamion", oCamion.IdCamion);
                    comandoCarga.Parameters.AddWithValue("@pesoCarga", c.Peso);
                    comandoCarga.Parameters.AddWithValue("@tipoCarga", c.TipoCarga.IdTipoCarga);
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

        public bool BorrarCamion(int nroCamion)
        {
            bool aux = true;
            SqlConnection conexion = Dominio.Servicio.ObtenerInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_BORRAR_CAMION",conexion,transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                Parametro param = new Parametro("@id_camion", nroCamion);
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);
                comando.ExecuteNonQuery();
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
                    conexion.Close();
            }
            return aux;
        }

        public bool ConfirmarCamion(Camion oCamion)
        {
            bool aux = true;
            //Creamos la transaccion como nula
            SqlTransaction transaccion = null;
            SqlConnection conexion = Dominio.Servicio.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                //Abro la conexion y despues abro la transaccion bajo esa conexion!
                transaccion = conexion.BeginTransaction();
                //Al crear el comando le pasamos x parametro: el string del comando, la conexion y la transaccion
                SqlCommand comando = new SqlCommand("SP_INSERTAR_CAMION", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@proxCamion", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.Parameters.AddWithValue("@patente", oCamion.Patente);
                comando.Parameters.AddWithValue("@pesoMax", oCamion.PesoMaximo);
                comando.Parameters.AddWithValue("@estadoCamion", oCamion.EstadoCamion.IdEstado);
                comando.ExecuteNonQuery();

                int nroCamion = (int)param.Value;

                foreach (Carga c in oCamion.ListaCargas)
                {
                    SqlCommand comandoCarga = new SqlCommand("SP_INSERTAR_CARGA", conexion, transaccion);
                    comandoCarga.CommandType = CommandType.StoredProcedure;
                    comandoCarga.Parameters.AddWithValue("@idCamion", nroCamion);
                    comandoCarga.Parameters.AddWithValue("@pesoCarga", c.Peso);
                    comandoCarga.Parameters.AddWithValue("@tipoCarga", c.TipoCarga.IdTipoCarga);
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

        public int ObtenerProximoCamion()
        {
            return Dominio.Servicio.ObtenerInstancia().ObtenerEscalar("SP_PROXIMO_CAMION","@next");
        }

        public List<Camion> TraerCamiones(List<Parametro> lParams,string nombreSP)
        {
            DataTable tabla = Dominio.Servicio.ObtenerInstancia().Consultar(nombreSP,lParams);
            List<Camion> lCamiones = new List<Camion>();
            foreach (DataRow r in tabla.Rows)
            {
                int nro = int.Parse(r["id_camion"].ToString());
                string pat = r["patente"].ToString();
                int id_est = int.Parse(r["estado_camion"].ToString());
                string est = r["estado"].ToString();
                int pMax = int.Parse(r["peso_maximo"].ToString());
                lCamiones.Add(new Camion(nro,pat,new EstadoCamion(id_est,est),pMax));
            }
            return lCamiones;
        }

        public Camion TraerCamionNro(int nroCamion)
        {
            Camion camion = new Camion();
            SqlConnection conexion = Dominio.Servicio.ObtenerInstancia().ObtenerConexion();
            SqlCommand comando = new SqlCommand();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_CAMION";
            Parametro param = new Parametro("@id_camion", nroCamion);
            comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            foreach (DataRow fila in tabla.Rows)
            {
                camion.IdCamion = Convert.ToInt32(fila["id_camion"].ToString());
                camion.Patente = fila["patente"].ToString();
                int id_est = Convert.ToInt32(fila["estado_camion"].ToString());
                string nom_est = fila["estado"].ToString();
                camion.EstadoCamion = new EstadoCamion(id_est, nom_est);
                camion.PesoMaximo = Convert.ToInt32(fila["peso_maximo"].ToString());
            }
            return camion;
        }

        public List<TipoCarga> TraerTipos()
        {
            DataTable tabla = Dominio.Servicio.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_CARGA");
            List<TipoCarga> lTiposCarga = new List<TipoCarga>();
            foreach(DataRow r in tabla.Rows)
            {
                int nro = int.Parse(r["id_tipo_carga"].ToString());
                string nom = r["nombre"].ToString();
                lTiposCarga.Add(new TipoCarga(nro, nom));
            }
            return lTiposCarga;
        }

        public List<EstadoCamion> TraerEstados()
        {
            List<EstadoCamion> lEstado = new List<EstadoCamion>();
            DataTable tabla = Dominio.Servicio.ObtenerInstancia().Consultar("SP_CONSULTAR_ESTADOS");
            foreach (DataRow r in tabla.Rows)
            {
                int nro = int.Parse(r["id_estado_camion"].ToString());
                string nom = r["estado"].ToString();
                lEstado.Add(new EstadoCamion(nro, nom));
            }
            return lEstado;
        }

        public Camion TraerCargas(Camion oCamion)
        {
            SqlConnection conexion = Dominio.Servicio.ObtenerInstancia().ObtenerConexion();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SP_CONSULTAR_CARGAS_CAMION",conexion);
            comando.CommandType = CommandType.StoredProcedure;
            Parametro param = new Parametro("@id_camion", oCamion.IdCamion);
            comando.Parameters.AddWithValue(param.Nombre, param.Valor);
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            foreach (DataRow r in tabla.Rows)
            {
                Carga nCarga = new Carga();
                nCarga.IdCarga = Convert.ToInt32(r["id_carga"].ToString());
                nCarga.Peso = Convert.ToDouble(r["peso"].ToString());
                int idTipo = Convert.ToInt32(r["tipo_carga"].ToString());
                string tipo = r["nombre"].ToString();
                nCarga.TipoCarga = new TipoCarga(idTipo,tipo);
                oCamion.AgregarCarga(nCarga);
            }
            conexion.Close();
            return oCamion;
        }
    }
}
