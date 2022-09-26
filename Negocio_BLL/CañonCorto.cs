using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class CañonCorto : Arma
    {
        string mensaje;
        public override string Disparar(Objetivo o)
        {
            if (o.distancia < 10)
            {
                mensaje = "Disparando certero.";
                
            }
            else
            {
                mensaje = "Disparo errado.";
            }
            return mensaje;

        }
    }
}
