using ReaLTaiizor.Util;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;
using System.Drawing;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using GestionAgraria.models;


namespace GestionAgraria.Core
{
    internal class Config
    {
        public static string application_name = "Gestión Agraria";
        public static string sql_connection_string = Environment.GetEnvironmentVariable("SQLITE_CONNECTION_STRING") ?? "Data Source=data.db";
        public static string sql_database_name = "GestionAgraria";
        public static string random_password_characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{}|;':,.<>?/~`";
        public static List<RoleModel> defaultRoles = new List<RoleModel>
        {
            new RoleModel {
                Name = "Administrador",
                Level = 1,
                ActivitiesAccess = AccessLevel.Admin,
                AnimalsAccess = AccessLevel.Admin,
                VegetablesAccess = AccessLevel.Admin,
                IndustriesAccess = AccessLevel.Admin,
                UsersAccess = AccessLevel.Admin,
                FormativeEnvironmentsAccess = AccessLevel.Admin
            },
            new RoleModel {
                Name = "Director",
                Level = 2,
                ActivitiesAccess = AccessLevel.Admin,
                AnimalsAccess = AccessLevel.Admin,
                VegetablesAccess = AccessLevel.Admin,
                IndustriesAccess = AccessLevel.Admin,
                UsersAccess = AccessLevel.Admin,
                FormativeEnvironmentsAccess = AccessLevel.Admin
            },
            new RoleModel {
                Name = "Jefe de área: Animales",
                Level = 3,
                ActivitiesAccess = AccessLevel.Read,
                AnimalsAccess = AccessLevel.Write,
                VegetablesAccess = AccessLevel.Read,
                IndustriesAccess = AccessLevel.Read,
                UsersAccess = AccessLevel.None,
                FormativeEnvironmentsAccess = AccessLevel.Write
            },
            new RoleModel {
                Name = "Jefe de área: Vegetales",
                Level = 3,
                ActivitiesAccess = AccessLevel.Write,
                AnimalsAccess = AccessLevel.Read,
                VegetablesAccess = AccessLevel.Write,
                IndustriesAccess = AccessLevel.Read,
                UsersAccess = AccessLevel.None,
                FormativeEnvironmentsAccess = AccessLevel.Read
            },
            new RoleModel {
                Name = "Jefe de área: Industria",
                Level = 3,
                ActivitiesAccess = AccessLevel.Write,
                AnimalsAccess = AccessLevel.Read,
                VegetablesAccess = AccessLevel.Read,
                IndustriesAccess = AccessLevel.Write,
                UsersAccess = AccessLevel.None,
                FormativeEnvironmentsAccess = AccessLevel.Read
            },
            new RoleModel { 
                Name = "Profesor",
                Level = 4,
                ActivitiesAccess = AccessLevel.Write,
                AnimalsAccess = AccessLevel.Write,
                VegetablesAccess = AccessLevel.Write,
                IndustriesAccess = AccessLevel.Read,
                UsersAccess = AccessLevel.None,
                FormativeEnvironmentsAccess = AccessLevel.Read
            },
            new RoleModel {
                Name = "Invitado",
                Level = 5,
                ActivitiesAccess = AccessLevel.Read,
                AnimalsAccess = AccessLevel.Read,
                VegetablesAccess = AccessLevel.Read,
                IndustriesAccess = AccessLevel.None,
                UsersAccess = AccessLevel.None,
                FormativeEnvironmentsAccess = AccessLevel.Read
            }
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
        public static List<string> defaultProcesoType = new List<string>
        {
            "En proceso",
            "Actividad",
            "Finalizado",
            "En lista"
        };
    }
    internal class UIConfig
    {
        public static int primary = 0x396f04; // Color primario
        public static int lightPrimary = 0x7dbd07; // Tono más claro del color primario
        public static int darkPrimary = 0x234602; // Tono más oscuro del color primario
        public static int accent = 0x7dbd07; // Color de acento
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
        public static string[] defaultProcesoType = new string[]
        {
            "En proceso",
            "Actividad",
            "Finalizado",
            "En lista"
        };
    }
}

