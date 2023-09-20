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
        bool ConfirmarCamion();
        Camion TraerCamionNro();
        bool ActualizarCamion();
        bool BorrarCamion();
        List<Camion> TraerCamiones();
    }
}
