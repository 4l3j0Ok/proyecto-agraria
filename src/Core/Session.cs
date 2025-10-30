using GestionAgraria.models;

namespace GestionAgraria.Core
{
    public static class Session
    {
        // Guarda el usuario actual en la sesión de la aplicación
        public static UserModel? CurrentUser { get; set; }
    }
}
