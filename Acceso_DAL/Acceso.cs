using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Acceso
    {
        SqlCommand cmd;

        string str = @"Data Source=GASGANO; Initial Catalog = SARAZA; Integrated Security = True";
        SqlConnection cn;
        public SqlConnection conexion()
        {
            cn = new SqlConnection(str);
            cn.Open();
            return cn;
        }

        public void CargarBitacora(string arma, int distancia, string disparo)
        {
            cn = new SqlConnection(str);
            cn.Open();
            string consulta = "insert into Bitacora(Arma, Distancia, Disparo) values ('" + arma + "','" + distancia + "', '" + disparo + "')";
            cmd = new SqlCommand(consulta, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
