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
    public partial class GetInForm : Form
    {
        public GetInForm()
        {
            InitializeComponent();
        }
        private void GetInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet22.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter2.Fill(this.hotelDataSet22.RoomReservation);
            // TODO: This line of code loads data into the 'hotelDataSet14.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter1.Fill(this.hotelDataSet14.RoomReservation);
            // TODO: This line of code loads data into the 'hotelDataSet13.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter.Fill(this.hotelDataSet13.RoomReservation);
        }
        private void button1_Click(object sender, EventArgs e)
        {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
                {
                    connection.Open();
                    using (var query = connection.CreateCommand())
                    {
                        int roomId = 0;
                        int guests = 0;
                        int money = 0;
                        DateTime Fdate = DateTime.Now;
                        DateTime Ldate = DateTime.Now;
                        query.CommandText = "SELECT RoomId, Guests, Fdate, Ldate FROM RoomReservation WHERE Id=@Id";
                        query.Parameters.AddWithValue("@Id", listBox1.SelectedValue);
                        using (var reader = query.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                roomId = reader.GetInt32(0);
                                guests = reader.GetInt32(1);
                                Fdate = reader.GetDateTime(2);
                                Ldate = reader.GetDateTime(3);
                            }
                        }
                        query.Parameters.Clear();
                        query.CommandText = "UPDATE Room SET Status = @status WHERE Id = @roomId";
                        query.Parameters.AddWithValue("@status", "Занят");
                        query.Parameters.AddWithValue("@roomId", roomId);
                        query.ExecuteNonQuery();
                        query.Parameters.Clear();
                        query.CommandText = "SELECT Money FROM Room WHERE Id=@roomId";
                        query.Parameters.AddWithValue("@roomId", roomId);
                        using (var reader = query.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                money = reader.GetInt32(0);
                            }
                        }
                        query.Parameters.Clear();
                        int days = Ldate.Subtract(Fdate).Days;
                        query.CommandText = "INSERT INTO Analytic (RoomId, Guests, Money, days, day) VALUES (@roomId, @guests, @money, @days, @day)";
                        query.Parameters.AddWithValue("@roomId", roomId);
                        query.Parameters.AddWithValue("@guests", guests);
                        query.Parameters.AddWithValue("@money", money*days);
                        query.Parameters.AddWithValue("@day", DateTime.Now);
                        query.Parameters.AddWithValue("@days", days);
                        query.ExecuteNonQuery();
                        query.CommandText = "DELETE RoomReservation WHERE Id = @id";
                        query.Parameters.AddWithValue("@id", listBox1.SelectedValue);
                        query.ExecuteNonQuery();
                        query.Parameters.Clear();
                        connection.Close();
                        // TODO: This line of code loads data into the 'hotelDataSet22.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter2.Fill(this.hotelDataSet22.RoomReservation);
                        // TODO: This line of code loads data into the 'hotelDataSet14.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter1.Fill(this.hotelDataSet14.RoomReservation);
                        // TODO: This line of code loads data into the 'hotelDataSet13.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter.Fill(this.hotelDataSet13.RoomReservation);
                    }
                }
        }
    }
}
