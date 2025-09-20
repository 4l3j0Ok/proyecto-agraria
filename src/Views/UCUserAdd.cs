using GestionAgraria.controllers;
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
    public partial class UCUserAdd : UserControl
    {
        private UserController userController;
        private UserModel currentUser;

        public UCUserAdd(UserModel user = null)
        {
            InitializeComponent();
            userController = new UserController();
            currentUser = user;
        }
    }
}
