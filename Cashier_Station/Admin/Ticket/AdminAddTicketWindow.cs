using Cashier_Station.Models;
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

namespace Cashier_Station
{
    public partial class AdminAddTicketWindow : Form
    {
        DataBase db;
        public AdminAddTicketWindow()
        {
            InitializeComponent();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевненні, що хочете додати цю інформацію?", "Додавання інформації", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {


                    db = new DataBase();
                    if (IdTicketTextBox.Text == "" || PriceTicketTextBox.Text == "" || RouteNumberTextBox.Text == "")
                    {
                        MessageBox.Show("Поля не можуть бути пустими або від'ємними", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.OpenConnection();
                        string query = "INSERT INTO ticket (id, RouteId, Price, IsActive) VAlUES (@id, @RouteId, @Price, @IsActive)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {

                            cmd.Parameters.AddWithValue("@id", int.Parse(IdTicketTextBox.Text));
                            cmd.Parameters.AddWithValue("@RouteId", int.Parse(RouteNumberTextBox.Text));
                            cmd.Parameters.AddWithValue("@Price", int.Parse(PriceTicketTextBox.Text));
                            cmd.Parameters.AddWithValue("@IsActive", false);


                            cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("Дані успішно додано");
                        MessageBox.Show("Дані успішно додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("При додаванні даних у таблицю ticket виникла помилка");
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
