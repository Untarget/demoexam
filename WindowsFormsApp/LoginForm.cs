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

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            if (login != "" && password != "")
            {
                byte role= 0;                
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K4ON2HK;Initial Catalog=hotel;User id=Student;Password=qwe123QWE"))
                {
                    connection.Open();
                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = "SELECT Role FROM Users WHERE login= @login and password= @password;";
                        query.Parameters.AddWithValue("@login", login);
                        query.Parameters.AddWithValue("@password", password);

                        using (var reader = query.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                role = reader.GetByte(0);
                            }
                        }
                        connection.Close();
                    }
                }
                switch (role)
                {
                    case 1:
                        {
                            this.Visible = false;
                            AdministratorMainForm _AdministratorMainForm = new AdministratorMainForm();
                            _AdministratorMainForm.Show();
                            break;
                        }
                    case 2:
                        {
                            this.Visible = false;
                            BossMainForm _BossMainForm = new BossMainForm();
                            _BossMainForm.Show();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Логин или пароль неверны");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }
    }
}

