using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionAgraria.models
{
    public class UserModel
    {
        public int? id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? phone { get; set; }
        public string? personId { get; set; }
        public int? roleId { get; set; }
        public int? isActive { get; set; } = 1;
    }
}
