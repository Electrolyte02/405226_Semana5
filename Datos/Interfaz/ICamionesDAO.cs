using _405226_Problema_1._6_.Dominio;
using _405226_Problema_1._6_.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405226_Problema_1._6_.Datos.Interfaz
{
    internal interface ICamionesDAO
    {
        int ObtenerProximoCamion();
        bool ConfirmarCamion(Camion oCamion);
        Camion TraerCamionNro(int nroCamion);
        bool ActualizarCamion(Camion oCamion);
        bool BorrarCamion(int nroCamion);
        List<Camion> TraerCamiones(List<Parametro> lParams, string nombreSP);
        List<TipoCarga> TraerTipos();
        List<EstadoCamion> TraerEstados();
        Camion TraerCargas(Camion oCamion);
    }
}
