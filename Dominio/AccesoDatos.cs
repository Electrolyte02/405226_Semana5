using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Dominio
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private string stringConexion = "Data Source=DESKTOP-BKGGIPD;Initial Catalog=405226_Problema1.6;Integrated Security=True";

        public AccesoDatos()
        {
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

        public DataTable ConsultarTabla(string sentencia)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public int EjecutarComando(string sentencia)
        {
            int aux = 0;
            Conectar();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            aux = Convert.ToInt32(param.Value);
            Desconectar();
            return aux;
        }
    }
}
