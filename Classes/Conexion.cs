using System.Configuration;
using MySql.Data.MySqlClient;

namespace accountableSystem.Classes
{
    internal static class Conexion
    {
        private static readonly string _cadena =
            ConfigurationManager.ConnectionStrings["accountableDB"].ConnectionString;

        public static MySqlConnection Abrir()
        {
            var con = new MySqlConnection(_cadena);
            con.Open();
            return con;
        }

        public static bool Probar()
        {
            try
            {
                using (var con = new MySqlConnection(_cadena)) { con.Open(); return true; }
            }
            catch { return false; }
        }
    }
}
