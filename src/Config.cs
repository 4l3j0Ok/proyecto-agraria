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
        public static string sql_connection_string = Environment.GetEnvironmentVariable("SQL_CONNECTION_STRING") ?? "";
        public static string sql_database_name = "GestionAgraria";
        public static string random_password_characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':,.<>?/~`";
    }
}
