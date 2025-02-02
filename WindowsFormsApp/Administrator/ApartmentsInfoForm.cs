using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ApartmentsInfoForm : Form
    {
        public ApartmentsInfoForm()
        {
            InitializeComponent();
        }

        private void ApartmentsInfoForm_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'hotelDataSet17.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet17.Room);
            }
            catch {}

        }
    }
}
