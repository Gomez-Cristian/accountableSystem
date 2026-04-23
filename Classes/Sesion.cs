namespace accountableSystem.Classes
{
    /// <summary>
    /// Guarda los datos del usuario que inició sesión.
    /// Se limpia al cerrar sesión.
    /// </summary>
    internal static class Sesion
    {
        public static int    IdUsuario      { get; set; }
        public static string NombreCompleto { get; set; }
        public static int    IdRol          { get; set; }
        public static string NombreRol      { get; set; }

        public static bool EsAdmin => IdRol == 1;

        public static void Limpiar()
        {
            IdUsuario      = 0;
            NombreCompleto = null;
            IdRol          = 0;
            NombreRol      = null;
        }
    }
}
