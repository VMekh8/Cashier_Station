using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Cashier_Station
{
    public partial class AdminAddRouteWindow : Form
    {
        DataBase db;
        public AdminAddRouteWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені що ви хочете додати цю інформацію?", "Додавання інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db = new DataBase();
                try
                {
                    if (NumberRoute.Text == "" || StartPoint.Text == "" || EndPoint.Text == "" 
                        || Transportid.Text == "" || SeatsNumber.Text == "")
                    {
                        MessageBox.Show("Поля не можуть бути пустими", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.OpenConnection();
                        string query = "INSERT INTO route (id, StartPoint, EndPoint, DateofStart, DateofEnd, SeatsNumber, TransportId) VALUES (@id, @StartPoint, @EndPoint, @DateofStart, @DateofEnd, @SeatsNumber, @TransportId)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(NumberRoute.Text));
                            cmd.Parameters.AddWithValue("@StartPoint", StartPoint.Text);
                            cmd.Parameters.AddWithValue("@EndPoint", EndPoint.Text);
                            cmd.Parameters.AddWithValue("@DateofStart", DateTime.Parse(bunifuDatepicker1.Value.ToString()));
                            cmd.Parameters.AddWithValue("@DateofEnd", DateTime.Parse(bunifuDatepicker2.Value.ToString()));
                            cmd.Parameters.AddWithValue("@SeatsNumber", int.Parse(SeatsNumber.Text));
                            cmd.Parameters.AddWithValue("@TransportId", int.Parse(Transportid.Text));

                            cmd.ExecuteNonQuery();
                        }

                        Console.Write("Дані успішно додані у базу даних");
                        MessageBox.Show("Дані успішно додані у базу даних", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("При додаванні даних у таблицю route виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("Дані не були додані до бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
