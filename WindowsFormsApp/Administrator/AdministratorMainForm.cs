using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Administrator;

namespace WindowsFormsApp
{
    public partial class AdministratorMainForm : Form
    {
        public AdministratorMainForm()
        {
            InitializeComponent();
        }
        private void buttonApartmentsInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ApartmentsInfoForm _ApartmentsInfoForm = new ApartmentsInfoForm();
                _ApartmentsInfoForm.Show();
            }
            catch {}
        }
        private void buttonReservaition_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaitionForm _ReservaitionForm = new ReservaitionForm();
                _ReservaitionForm.Show();
            }
            catch {}
        }
        private void buttonGetOut_Click(object sender, EventArgs e)
        {
            try
            {
                GetInForm _GetInForm = new GetInForm();
                _GetInForm.Show();
            }
            catch {};
        }
        private void buttonGetIn_Click(object sender, EventArgs e)
        {
            try
            {
                GetOutForm _GetOutForm = new GetOutForm();
                _GetOutForm.Show();
            }
            catch {}
        }
        private void buttonCheckEmployeesWork_Click(object sender, EventArgs e)
        {
            try
            {
                CleaningCalendarForm _CleaningCalendarForm = new CleaningCalendarForm();
                _CleaningCalendarForm.Show();
            }
            catch {}
        }
        private void AdministratorMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
