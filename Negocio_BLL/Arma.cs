using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public abstract class Arma
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
        public abstract string Disparar(Objetivo o);
    }
}
