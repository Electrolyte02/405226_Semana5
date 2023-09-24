using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Dominio
{
    internal class TipoCarga
    {
        public int IdTipoCarga { get; set; }
        public string NombreTipo { get; set; }

        public TipoCarga()
        {
                IdTipoCarga = 0;
                NombreTipo = string.Empty;
        }

        public TipoCarga(int id,string nom)
        {
            IdTipoCarga = id;
            NombreTipo = nom;
        }

        public override string ToString()
        {
            return NombreTipo;
        }
    }
}
