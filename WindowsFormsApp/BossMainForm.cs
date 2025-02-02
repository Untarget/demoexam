using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class BossMainForm : Form
    {
        public BossMainForm()
        {
            InitializeComponent();
        }
        private double getProcent(in string date)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
            {
                connection.Open();
                using (var query = connection.CreateCommand())
                {
                    int analitycCount = 0;
                    int roomCount = 0;
                    query.CommandText = "SELECT SUM(days) FROM Analytic WHERE Day = @day";
                    query.Parameters.AddWithValue("@day", date);
                    using (var reader = query.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                analitycCount = reader.GetInt32(0);
                            }
                        }
                       catch
                        {
                            MessageBox.Show("На данный день отсутствует аналитика");
                        }
                    }
                    query.CommandText = "SELECT COUNT(*) FROM Room";
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomCount = reader.GetInt32(0);
                        }
                    }
                    connection.Close();
                    return (double)analitycCount / roomCount;
                }
            }
        }
        private double GetADR(in string date)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
            {
                connection.Open();
                using (var query = connection.CreateCommand())
                {
                    int Money = 0;
                    int Days = 0;
                    query.CommandText = "SELECT SUM(Money), SUM(days) FROM Analytic WHERE Day = @day";
                    query.Parameters.AddWithValue("@day", date);
                    using (var reader = query.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Money = reader.GetInt32(0);
                                Days = reader.GetInt32(1);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("На данный день отсутствует аналитика");
                        }
                    }
                    connection.Close();
                    return (double)Money * 40 / 100 / Days;
                }
            }
        }
        private double getRevPAR(in string date)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
            {
                connection.Open();
                using (var query = connection.CreateCommand())
                {
                    int days = 0;
                    query.CommandText = "SELECT SUM(days) FROM Analytic WHERE Day = @day";
                    query.Parameters.AddWithValue("@day", date);
                    using (var reader = query.ExecuteReader())
                        try
                        {
                            while (reader.Read())
                            {
                                days = reader.GetInt32(0);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("На данный день отсутствует аналитика");
                        }
                    return (double)GetADR(date) / days;
                }
            }
        }
        private void buttonRevPAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{getRevPAR(dateTimePicker3.Value.ToString())}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{getProcent(dateTimePicker2.Value.ToString())}");
        }
        private void buttonADR1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{GetADR(dateTimePicker1.Value.ToString())}");
        }
        private void BossMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet30.Analytic' table. You can move, or remove it, as needed.
            this.analyticTableAdapter.Fill(this.hotelDataSet30.Analytic);
        }

        private void BossMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
