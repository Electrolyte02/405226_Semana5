using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Dominio
{
    internal class EstadoCamion
    {
        public int IdEstado { get; set; }
        public string Estado { get; set; }

        public EstadoCamion()
        {
            IdEstado = 0;
            Estado = string.Empty;
        }

        public EstadoCamion(int id,string est)
        {
            IdEstado = id;
            Estado = est;
        }
        public override string ToString()
        {
            return Estado;
        }
    }
}
