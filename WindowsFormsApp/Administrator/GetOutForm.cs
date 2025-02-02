using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Administrator
{
    public partial class GetOutForm : Form
    {
        public GetOutForm()
        {
            InitializeComponent();
        }
        private void GetOutForm_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'hotelDataSet23.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter2.Fill(this.hotelDataSet23.Room);
                // TODO: This line of code loads data into the 'hotelDataSet16.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter1.Fill(this.hotelDataSet16.Room);
                // TODO: This line of code loads data into the 'hotelDataSet15.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet15.Room);
            }
            catch {}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
                {
                    connection.Open();
                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = "UPDATE Room SET Status = @status WHERE Id=@Id";
                        query.Parameters.AddWithValue("@status", "Грязный");
                        query.Parameters.AddWithValue("@Id", listBox1.SelectedValue);
                        query.ExecuteNonQuery();
                        connection.Close();
                    }
                    // TODO: This line of code loads data into the 'hotelDataSet23.Room' table. You can move, or remove it, as needed.
                    this.roomTableAdapter2.Fill(this.hotelDataSet23.Room);
                    // TODO: This line of code loads data into the 'hotelDataSet16.Room' table. You can move, or remove it, as needed.
                    this.roomTableAdapter1.Fill(this.hotelDataSet16.Room);
                    // TODO: This line of code loads data into the 'hotelDataSet15.Room' table. You can move, or remove it, as needed.
                    this.roomTableAdapter.Fill(this.hotelDataSet15.Room);
                }
            }
            catch {}
        }
    }
}
