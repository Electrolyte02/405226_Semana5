using _405226_Problema_1._6_.Datos.Interfaz;
using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Servicio.Interfaz
{
    internal interface IServicio
    {
        int ObtenerNroProxCamion();
        List<TipoCarga> TraerTiposCarga();
        List<EstadoCamion> TraerEstadosCamion();
        Camion TraerCargas(Camion oCamion);
        Camion TraerCamion(int nroCamion);
        List<Camion> TraerCamiones(List<Parametro> lParams,string comandoSP);
        bool ConfirmarCamion(Camion oCamion);
        bool ActualizarCamion(Camion oCamion);
        bool BorrarCamion(int nroCamion);
    }
}
