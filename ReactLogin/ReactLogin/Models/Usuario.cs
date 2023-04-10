using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReactLogin.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public static Usuario Loguear(string usuario,string contraseña)
        {
            Datos.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM usuario where NombreUsuario = @NombreUsuario and contraseña = @Contraseña";
            cmd.Parameters.AddWithValue("@NombreUsuario",usuario);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);
            cmd.Connection = Datos.conx;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            Usuario u = new Usuario();

            if (dr.Read())
            {
                u.Id = int.Parse(dr["Id"].ToString());
                u.NombreUsuario = dr["NombreUsuario"].ToString();
                u.Contraseña = dr["Contraseña"].ToString();
            }

            Datos.Desconectar();

            return u;
        }
    }
}