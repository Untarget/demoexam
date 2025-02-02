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
    public partial class ReservaitionForm : Form
    {
        public ReservaitionForm()
        {
            InitializeComponent();
        }
        private void ReservaitionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet29.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter5.Fill(this.hotelDataSet29.RoomReservation);
            // TODO: This line of code loads data into the 'hotelDataSet28.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter4.Fill(this.hotelDataSet28.RoomReservation);
            // TODO: This line of code loads data into the 'hotelDataSet26.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter3.Fill(this.hotelDataSet26.RoomReservation);
            // TODO: This line of code loads data into the 'hotelDataSet25.RoomReservation' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hotelDataSet12.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter1.Fill(this.hotelDataSet12.RoomReservation);
            // TODO: This line of code loads data into the 'hotelDataSet11.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelDataSet11.Room);
            // TODO: This line of code loads data into the 'hotelDataSet10.RoomReservation' table. You can move, or remove it, as needed.
            this.roomReservationTableAdapter.Fill(this.hotelDataSet10.RoomReservation);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Проверяем на то, если дата заселения выше, чем дата выселения
                if (dateTimePickerStart.Value < dateTimePickerEnd.Value)
                {
                //Проверяем ФИО на пустоту
                    if (textBoxFnameClient.Text.Trim().Length > 0)
                    {
                    //Проверяем количество гостей на Int32
                        if (Int32.TryParse(textBoxGuestCount.Text.Trim(), out int guests))
                        {
                            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=Hotel;User id=Student;Password=qwe123QWE"))
                            {
                                connection.Open();
                                using (var query = connection.CreateCommand())
                                {
                                //Добавляем в БД запись о резервировании
                                    query.CommandText = "INSERT INTO RoomReservation (RoomId, Fdate, Ldate, ClientFname, Guests) VALUES (@roomId, @Fdate, @Ldate, @cFname, @gCount)";
                                    query.Parameters.AddWithValue("@roomId", listBoxRoom.SelectedValue);
                                    query.Parameters.AddWithValue("@Fdate", dateTimePickerStart.Value);
                                    query.Parameters.AddWithValue("@Ldate", dateTimePickerEnd.Value);
                                    query.Parameters.AddWithValue("@cFname", textBoxFnameClient.Text.Trim());
                                    query.Parameters.AddWithValue("@gCount", textBoxGuestCount.Text.Trim());
                                    query.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }
                        //Создается самим фреймворком
                        // TODO: This line of code loads data into the 'hotelDataSet29.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter5.Fill(this.hotelDataSet29.RoomReservation);
                        // TODO: This line of code loads data into the 'hotelDataSet28.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter4.Fill(this.hotelDataSet28.RoomReservation);
                        // TODO: This line of code loads data into the 'hotelDataSet26.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter3.Fill(this.hotelDataSet26.RoomReservation);
                        // TODO: This line of code loads data into the 'hotelDataSet25.RoomReservation' table. You can move, or remove it, as needed.
                        // TODO: This line of code loads data into the 'hotelDataSet12.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter1.Fill(this.hotelDataSet12.RoomReservation);
                        // TODO: This line of code loads data into the 'hotelDataSet11.Room' table. You can move, or remove it, as needed.
                        this.roomTableAdapter.Fill(this.hotelDataSet11.Room);
                        // TODO: This line of code loads data into the 'hotelDataSet10.RoomReservation' table. You can move, or remove it, as needed.
                        this.roomReservationTableAdapter.Fill(this.hotelDataSet10.RoomReservation);
                    }
                        else
                        {
                            MessageBox.Show("Неверное количество гостей");
                        }
                    }                    
                    else
                    {
                        MessageBox.Show("Неверное ФИО клиента");
                    }
                }
                else
                {
                    MessageBox.Show("Неверное время");
                }
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
                        query.CommandText = "DELETE RoomReservation WHERE Id = @id";
                        query.Parameters.AddWithValue("@id", listBoxDeleteItem.SelectedValue);
                        query.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // TODO: This line of code loads data into the 'hotelDataSet29.RoomReservation' table. You can move, or remove it, as needed.
                this.roomReservationTableAdapter5.Fill(this.hotelDataSet29.RoomReservation);
                // TODO: This line of code loads data into the 'hotelDataSet28.RoomReservation' table. You can move, or remove it, as needed.
                this.roomReservationTableAdapter4.Fill(this.hotelDataSet28.RoomReservation);
                // TODO: This line of code loads data into the 'hotelDataSet26.RoomReservation' table. You can move, or remove it, as needed.
                this.roomReservationTableAdapter3.Fill(this.hotelDataSet26.RoomReservation);
                // TODO: This line of code loads data into the 'hotelDataSet25.RoomReservation' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'hotelDataSet12.RoomReservation' table. You can move, or remove it, as needed.
                this.roomReservationTableAdapter1.Fill(this.hotelDataSet12.RoomReservation);
                // TODO: This line of code loads data into the 'hotelDataSet11.Room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet11.Room);
                // TODO: This line of code loads data into the 'hotelDataSet10.RoomReservation' table. You can move, or remove it, as needed.
                this.roomReservationTableAdapter.Fill(this.hotelDataSet10.RoomReservation);
            }
            catch {}
        }
    }
}
