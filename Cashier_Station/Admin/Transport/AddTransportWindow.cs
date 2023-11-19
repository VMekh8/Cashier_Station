using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Cashier_Station.Admin
{
    public partial class AddTransportWindow : Form
    {
        DataBase db;
        public AddTransportWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var DialogRes = MessageBox.Show("Ви справді бажаєде додати цю інформацію?", "Додавання інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogRes  == DialogResult.Yes)
            {
                if (IdTrasportTextBox.Text == "" || NameTransportTextBox.Text == "" || int.Parse(IdTrasportTextBox.Text) <= 0)
                {
                    MessageBox.Show("Поля не можуть бути пустими або від'ємними", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    try
                    {
                        db = new DataBase();
                        db.OpenConnection();

                        string query = "INSERT INTO transport (id, name) VALUES (@id, @name)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(IdTrasportTextBox.Text));
                            cmd.Parameters.AddWithValue("@name", NameTransportTextBox.Text.ToString());

                            cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("Дані успішно додано");
                        MessageBox.Show("Дані успішно додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("При додаванні даних у таблицю transport виникла помилка");
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
}
