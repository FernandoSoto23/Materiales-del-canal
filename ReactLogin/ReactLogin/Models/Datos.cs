using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace ReactLogin.Models
{
    public class Datos
    {
        public static SqlConnection conx = new SqlConnection();

        public static void Conectar()
        {
            string cadena = "server=DESKTOP-GMLFIUN\\SQLEXPRESS;database=reactLogin;integrated security=yes;";
            conx.ConnectionString = cadena;
            conx.Open();
        }

        public static void Desconectar()
        {
            if (conx != null && conx.State == System.Data.ConnectionState.Open)
                conx.Close();
        }
    }
}