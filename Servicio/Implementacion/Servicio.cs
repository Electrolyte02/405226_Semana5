using _405226_Problema_1._6_.Datos.Implementacion;
using _405226_Problema_1._6_.Datos.Interfaz;
using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using _405226_Problema_1._6_.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Servicio.Implementacion
{
    internal class Servicio:IServicio
    {
        private ICamionesDAO camionesDao;

        public Servicio()
        {
            camionesDao = new CamionesDAO();
        }

        public bool ActualizarCamion(Camion oCamion)
        {
            return camionesDao.ActualizarCamion(oCamion);
        }

        public bool BorrarCamion(int nroCamion)
        {
            return camionesDao.BorrarCamion(nroCamion);
        }

        public bool ConfirmarCamion(Camion oCamion)
        {
            return camionesDao.ConfirmarCamion(oCamion);
        }

        public int ObtenerNroProxCamion()
        {
            return camionesDao.ObtenerProximoCamion();
        }

        public Camion TraerCamion(int nroCamion)
        {
            return camionesDao.TraerCamionNro(nroCamion);
        }

        public List<Camion> TraerCamiones(List<Parametro> lParams, string comandoSP)
        {
            return camionesDao.TraerCamiones(lParams, comandoSP);
        }

        public Camion TraerCargas(Camion oCamion)
        {
            return camionesDao.TraerCargas(oCamion);
        }

        public List<EstadoCamion> TraerEstadosCamion()
        {
            return camionesDao.TraerEstados();
        }

        public List<TipoCarga> TraerTiposCarga()
        {
            return camionesDao.TraerTipos();
        }
    }
}
