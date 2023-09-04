using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Entidades
{
    internal class Carga
    {
        private double peso;
        private int tipoCarga;

        public Carga()
        {
            peso = 0;
            tipoCarga = 0;
        }

        public Carga(double p,int t)
        {
            peso= p; tipoCarga = t;
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int TipoCarga
        {
            get { return tipoCarga; }
            set { tipoCarga = value; }
        }

        public override string ToString()
        {
            return " Peso:" + peso;
        }
    }
}
