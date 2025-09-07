using GestionAgraria.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAgraria.Views
{
    public partial class UCUserCard : UserControl
    {
        public UCUserCard(UserModel user)
        {
            InitializeComponent();
            lblUserName.Text = user.name;
            lblUserArea.Text = user.username;
        }
    }
}
