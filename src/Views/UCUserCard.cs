﻿using GestionAgraria.models;
using GestionAgraria.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace GestionAgraria.Views
{
    public partial class UCUserCard : UserControl
    {
        private UserModel _user;

        public UCUserCard(UserModel user)
        {
            InitializeComponent();
            _user = user;

            lblUserName.Text = user.Name;
            lblUserUsername.Text = user.Username;
            lblUserArea.Text = user.Role?.Name ?? "Sin rol";
            lblUserPhone.Text = user.Phone;
            Utils.CardSetupClickEvent(this, OnUserCardClick);
        }

        private void OnUserCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_user);
        }

        public static void OpenFormAdd(UserModel user)
        {
            UCUserAdd userAdd = new UCUserAdd(user);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(userAdd, formPrincipal.tabUsers);
        }
    }
}
