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
    internal class Servicio
    {
        private SqlConnection conexion;
        private string stringConexion = "Data Source=DESKTOP-BKGGIPD;Initial Catalog=405226_Problema1.6;Integrated Security=True";
        private static Servicio instancia;
        private Servicio() 
        {
            conexion = new SqlConnection(stringConexion);
        }

        public static Servicio ObtenerInstancia()
        {
            if(instancia == null)
            {
                instancia = new Servicio();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        private void Conectar()
        {
            conexion.Open();
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public int ObtenerEscalar(string sentencia, string nomParam)
        {
            int aux = 0;
            Conectar();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            SqlParameter param = new SqlParameter(nomParam, SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            Desconectar();
            aux = (int)param.Value;
            return aux;
        }

        internal DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        internal DataTable Consultar(string nombreSP,List<Parametro> lParams)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametro p in lParams)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }
    }
}
