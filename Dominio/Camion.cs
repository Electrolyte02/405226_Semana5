using _405226_Problema_1._6_.Dominio;
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
        private EstadoCamion estadoCamion;
        private int pesoMaximo;
        private List<Carga> listaCargas;

        public Camion()
        {
            idCamion = 0;
            patente = string.Empty;
            estadoCamion = null;
            pesoMaximo = 0;
            listaCargas = new List<Carga>();
        }

        public Camion(int id, string p, EstadoCamion e, int pesoM)
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

        public EstadoCamion EstadoCamion
        {
            get { return estadoCamion; }
            set { estadoCamion = value; }
        }

        public int PesoMaximo
        {
            get { return pesoMaximo; }
            set { pesoMaximo = value; }
        }

        public List<Carga> ListaCargas
        {
            get { return listaCargas; }
            set { listaCargas = value; }
        }

        public override string ToString()
        {
            return "Camion: " + patente;
        }

        public double PesoRestante()
        {
            double aux = 0;
            foreach(Carga c in listaCargas)
            {
                aux += c.Peso;
            }
            return pesoMaximo - aux;
        }
        //Metodos para manejar los detalles, agregar o quitar!
        public void AgregarCarga(Carga nCarga)
        {
            listaCargas.Add(nCarga);
        }

        public void QuitarCarga(int posicion)
        {
            listaCargas.RemoveAt(posicion);
        }

        //Metodo para calcular el total de cargas pa q no se rompa
        public double CalcularTotal()
        {
            double aux = 0;
            foreach(Carga c in listaCargas)
            {
                aux += c.Peso;
            }
            return aux;
        }
    }
}
