using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAgraria.Core;
using GestionAgraria.Models;

namespace GestionAgraria.Views
{
    public partial class UCActivityRecordCard : UserControl
    {
        private ActivityRecordModel _activity;
        public UCActivityRecordCard(ActivityRecordModel activity)
        {
            InitializeComponent();
            _activity = activity;

            lblTitle.Text = activity.Titulo;
            lblFecha.Text = activity.RecordDate.ToShortDateString();
            lblStateRecord.Text = activity.StateActivity;
            lblObservation.Text = activity.Observations;
            Utils.CardSetupClickEvent(this, OnActivityCardClick);
        }

        private void OnActivityCardClick(object? sender, EventArgs? e)
        {
            OpenFormAdd(_activity);
        }

        public static void OpenFormAdd(ActivityRecordModel acti)
        {
            UCActivityRecordAdd activityAdd = new UCActivityRecordAdd(null, acti);
            FormPrincipal? formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();
            formPrincipal?.VerFormularioTab(activityAdd, formPrincipal.tabActividad);
        }
    }
}
