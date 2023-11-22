using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Station.Admin.Authentication
{
    public partial class Login : Form
    {
        MainWindow mainWindow;
        DataBase db = new DataBase();   
        public Login(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Не всі поля заповнені\nАвторизація неможлива", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    db.OpenConnection();
                    string query = "SELECT * FROM workers WHERE login = @login AND password = @pass";

                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@login", LoginTextBox.Text);
                        cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text);


                        DataTable table = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            mainWindow.OpenInWindow(new AdminPanelWindowForm());
                        }
                        else
                        {
                            MessageBox.Show("Невірний логін або пароль\n        Спробуйте знову", "Авторизація неможлива!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoginTextBox.Text = string.Empty;
                            PasswordTextBox.Text = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Авторизація неможлива");
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("При авторизації виникла помилка", "Авторизація", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            mainWindow.OpenInWindow(new Register(mainWindow));
        }
    }
}
