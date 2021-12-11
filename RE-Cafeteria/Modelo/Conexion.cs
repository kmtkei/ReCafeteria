using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RE_Cafeteria.Modelo
{
    public class Conexion
    {
        string cadenaConexion = "Data Source = DESKTOP-UUS18BO\\SQLEXPRESS;initial Catalog=RECAFETERIA; Integrated Security = True";
        public SqlConnection conectar = new SqlConnection();

        public Conexion()
        {
            conectar.ConnectionString = cadenaConexion;
        }

        public void abrir() {

            if (conectar.State == 0) {
                conectar.Open();
            }
        }

        public void cerrar()
        {

            if (conectar.State != 0)
            {
                conectar.Close();
            }
        }



    }
}
