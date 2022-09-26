using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Conexion
    {
        Acceso_DAL.Acceso mapper = new Acceso_DAL.Acceso();

        public void conectarBD()
        {
            mapper.conexion();
        }

        public void registrar(string arma, int distancia, string disparo)
        {
            mapper.CargarBitacora(arma, distancia, disparo);
        }
    }
}
