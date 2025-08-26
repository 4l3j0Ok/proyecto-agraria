using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAgraria
{
    internal class Config
    {
        public static string application_name = "Gestión Agraria";
        public static string sql_connection_string = Environment.GetEnvironmentVariable("SQLITE_CONNECTION_STRING") ?? "Data Source=data.db";
        public static string sql_database_name = "GestionAgraria";
        public static string random_password_characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':,.<>?/~`";
        public static Dictionary<string, string> defaultRoles = new Dictionary<string, string>
        {
            { "admin", "Administrador" },
            { "director", "Director" },
            { "jefe_area", "Jefe de Área" },
            { "profesor", "Profesor" },
            { "invitado", "Invitado" }
        };
    }
    internal class ColorScheme
    {
        public static int primary = 0x23631C;
        public static int secondary = 0x50E340;
        public static int background = 0xEEEEEE;
        public static int accent = 0x44C136;
    }
}
