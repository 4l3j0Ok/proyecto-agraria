using GestionAgraria.models;

namespace GestionAgraria.Core
{
    public static class Session
    {
        // Guarda el usuario actual en la sesi�n de la aplicaci�n
        public static UserModel? CurrentUser { get; set; }
    }
}
