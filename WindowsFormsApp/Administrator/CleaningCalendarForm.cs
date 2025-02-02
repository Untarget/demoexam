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
    public partial class CleaningCalendarForm : Form
    {
        public CleaningCalendarForm()
        {
            InitializeComponent();
        }
        private void CleaningCalendarForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hotelDataSet24.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter4.Fill(this.hotelDataSet24.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet21.Employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter1.Fill(this.hotelDataSet21.Employee);
                // TODO: This line of code loads data into the 'hotelDataSet18.CleaningCalendar' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet6.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter2.Fill(this.hotelDataSet6.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet5.CleaningCalendar' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet4.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter.Fill(this.hotelDataSet4.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet3.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet3.Room);
                // TODO: This line of code loads data into the 'hotelDataSet.Employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.hotelDataSet.Employee);
            }
            catch { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
                {
                    connection.Open();
                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = "DELETE CleaningCalendar WHERE Id = @id";
                        query.Parameters.AddWithValue("@id", listBoxDeleteItem.SelectedValue);
                        query.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // TODO: This line of code loads data into the 'hotelDataSet24.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter4.Fill(this.hotelDataSet24.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet21.Employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter1.Fill(this.hotelDataSet21.Employee);
                // TODO: This line of code loads data into the 'hotelDataSet18.CleaningCalendar' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet6.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter2.Fill(this.hotelDataSet6.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet5.CleaningCalendar' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet4.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter.Fill(this.hotelDataSet4.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet3.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet3.Room);
                // TODO: This line of code loads data into the 'hotelDataSet.Employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.hotelDataSet.Employee);
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(textBoxHour.Text, out int hour) && hour > 0 && hour < 24)
                {
                    if (Int32.TryParse(textBoxMinute.Text, out int minute) && minute > 0 && minute < 60)
                    {
                        using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
                        {
                            connection.Open();
                            using (var query = connection.CreateCommand())
                            {
                                query.CommandText = "INSERT INTO CleaningCalendar (RoomId, EmployeeId, Day, Time, Status) VALUES (@roomId, @employeeId, @day, @time, @status)";
                                query.Parameters.AddWithValue("@day", dateTimePickerDate.Value);
                                query.Parameters.AddWithValue("@time", $"{hour}:{minute}");
                                query.Parameters.AddWithValue("@employeeId", listBoxEmployee.SelectedValue);
                                query.Parameters.AddWithValue("@roomId", listBoxRoom.SelectedValue);
                                query.Parameters.AddWithValue("@status", "Ожидается");
                                query.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                        // TODO: This line of code loads data into the 'hotelDataSet24.CleaningCalendar' table. You can move, or remove it, as needed.
                        this.cleaningCalendarTableAdapter4.Fill(this.hotelDataSet24.CleaningCalendar);
                        // TODO: This line of code loads data into the 'hotelDataSet21.Employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter1.Fill(this.hotelDataSet21.Employee);
                        // TODO: This line of code loads data into the 'hotelDataSet18.CleaningCalendar' table. You can move, or remove it, as needed.
                        // TODO: This line of code loads data into the 'hotelDataSet6.CleaningCalendar' table. You can move, or remove it, as needed.
                        this.cleaningCalendarTableAdapter2.Fill(this.hotelDataSet6.CleaningCalendar);
                        // TODO: This line of code loads data into the 'hotelDataSet5.CleaningCalendar' table. You can move, or remove it, as needed.
                        // TODO: This line of code loads data into the 'hotelDataSet4.CleaningCalendar' table. You can move, or remove it, as needed.
                        this.cleaningCalendarTableAdapter.Fill(this.hotelDataSet4.CleaningCalendar);
                        // TODO: This line of code loads data into the 'hotelDataSet3.Room' table. You can move, or remove it, as needed.
                        this.roomTableAdapter.Fill(this.hotelDataSet3.Room);
                        // TODO: This line of code loads data into the 'hotelDataSet.Employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter.Fill(this.hotelDataSet.Employee);
                    }
                    else
                    {
                        MessageBox.Show("Указано неправильное время");
                    }
                }
                else
                {
                    MessageBox.Show("Указано неправильное время");
                }
            }
            catch {}
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
                {
                    connection.Open();
                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = "UPDATE CleaningCalendar SET Status = @status WHERE Id = @id";
                        query.Parameters.AddWithValue("@id", listBoxChangeItem.SelectedValue);
                        query.Parameters.AddWithValue("@status", listBoxStatus.SelectedItem);
                        query.ExecuteNonQuery();
                        if (listBoxStatus.SelectedItem == "Выполнено")
                        {
                            int roomId = 0;
                            query.CommandText = "SELECT RoomId FROM CleaningCalendar WHERE Id=@Idroom";
                            query.Parameters.AddWithValue("@Idroom", listBoxChangeItem.SelectedValue);
                            using (var reader = query.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    roomId = reader.GetInt32(0);
                                }
                            }
                            query.CommandText = "UPDATE Room SET Status = @status2 WHERE Id=@IDup";
                            query.Parameters.AddWithValue("@status2", "Чистый");
                            query.Parameters.AddWithValue("@IDup", roomId);
                            query.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                // TODO: This line of code loads data into the 'hotelDataSet24.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter4.Fill(this.hotelDataSet24.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet21.Employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter1.Fill(this.hotelDataSet21.Employee);
                // TODO: This line of code loads data into the 'hotelDataSet18.CleaningCalendar' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet6.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter2.Fill(this.hotelDataSet6.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet5.CleaningCalendar' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet4.CleaningCalendar' table. You can move, or remove it, as needed.
                this.cleaningCalendarTableAdapter.Fill(this.hotelDataSet4.CleaningCalendar);
                // TODO: This line of code loads data into the 'hotelDataSet3.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet3.Room);
                // TODO: This line of code loads data into the 'hotelDataSet.Employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.hotelDataSet.Employee);
            }
            catch {}
        }
    }
}
