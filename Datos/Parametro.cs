using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Dominio
{
    internal class Parametro
    {
        private string nombre;
        private object valor;

        public Parametro()
        {
            nombre = string.Empty;
            valor = null;
        }

        public Parametro(string n, object v)
        {
            this.nombre = n;
            this.valor = v;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
