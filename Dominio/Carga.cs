﻿using _405226_Problema_1._6_.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Entidades
{
    internal class Carga
    {
        private int idCarga;
        private double peso;
        private TipoCarga tipoCarga;

        public Carga()
        {
            idCarga = 0;
            peso = 0;
            tipoCarga = null;
        }

        public Carga(int i,double p,TipoCarga t)
        {
            idCarga = i; peso= p; tipoCarga = t;
        }

        public int IdCarga
        {
            get { return idCarga; }
            set {idCarga = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public TipoCarga TipoCarga
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
