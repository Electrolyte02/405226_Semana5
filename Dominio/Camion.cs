using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Entidades
{
    internal class Camion
    {
        private int idCamion;
        private string patente;
        private int estadoCamion;
        private int pesoMaximo;
        private List<Carga> listaCargas;

        public Camion()
        {
            idCamion = 0;
            patente = string.Empty;
            estadoCamion = 0;
            pesoMaximo = 0;
            listaCargas = new List<Carga>();
        }

        public Camion(int id, string p, int e, int pesoM)
        {
            idCamion = id;
            patente = p;
            estadoCamion = e;
            pesoMaximo = pesoM;
            listaCargas = new List<Carga>();
        }

        public int IdCamion
        {
            get { return idCamion; }
            set { idCamion = value; }
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public int EstadoCamion
        {
            get { return estadoCamion; }
            set { estadoCamion = value; }
        }

        public int PesoMaximo
        {
            get { return pesoMaximo; }
            set { pesoMaximo = value; }
        }

        public override string ToString()
        {
            return "Camion: " + patente;
        }
    }
}
