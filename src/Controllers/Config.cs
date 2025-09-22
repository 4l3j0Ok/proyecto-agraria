using ReaLTaiizor.Util;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;
using System.Drawing;

namespace GestionAgraria
{
    internal class Config
    {
        public static string application_name = "Gestión Agraria";
        public static string sql_connection_string = Environment.GetEnvironmentVariable("SQLITE_CONNECTION_STRING") ?? "Data Source=data.db";
        public static string sql_database_name = "GestionAgraria";
        public static string random_password_characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':,.<>?/~`";
        public static List<string> defaultRoles = new List<string>
        {
            "Administrador",
            "Director",
            "Jefe de area",
            "Docente",
            "Invitado"
        };
        public static Bitmap default_profile_picture = Properties.Resources.user_placeholder;
        public static List<string> defaultAnimalTypes = new List<string>
        {
            "Vaca",
            "Cerdo",
            "Oveja",
            "Caballo",
            "Gallina",
            "Pato",
            "Cabra",
            "Conejo"
        };
        public static List<string> defaultAreas = new List<string>
        {
            "Animales",
            "Vegetales",
            "Industria",
            "Mixto"
        };
    }
    internal class ColorScheme
    {
        public static int primary = 0x396f04; // Color primario
        public static int lightPrimary = 0x7dbd07; // Tono más claro del color primario
        public static int darkPrimary = 0x234602; // Tono más oscuro del color primario
        public static int accent = 0x7a3f00; // Color de acento
        public static int background = 0xEEEEEE; // Color de fondo

        public static MaterialSkinManager GetSkinManager()
        {
            MaterialSkinManager materialSkinManager;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialColorScheme(
                primary: primary,
                darkPrimary: darkPrimary,
                lightPrimary: lightPrimary,
                accent: accent,
                textShade: MaterialTextShade.LIGHT
            );
            return materialSkinManager;
        }
    }
    internal class TabConfig
    {
        public static string[] productiveStates = new string[]
        {
            "Productivo",
            "Enfermo",
            "Embarazada",
            "Crecimiento"
        };
    }
}

