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

namespace Cashier_Station.Admin
{
    public partial class InterMediateRouteWindow : Form
    {
        DataBase db = new DataBase();
        public InterMediateRouteWindow()
        {
            InitializeComponent();
            FillDropDown();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDropDown()
        {
            List<string> routeid = new List<string>();
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM route";

                using (MySqlCommand cmd =  new MySqlCommand(query, db.GetConnection()))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) 
                    {
                        routeid.Add(reader["id"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("При завантаженні даних з бази даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                db.CloseConnection();
            }

            foreach (var item in routeid)
            {
                Routeid.AddItem(item.ToString());
                RouteIdDelete.AddItem(item.ToString());
            }
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевненні, що хочете додати цю інформацію?", "Додавання інформації",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (NameTransportTextBox.Text == "" || DistanceFromStart.Text == "" || DistanceToEnd.Text == "")
                {
                    MessageBox.Show("Поля не можуть бути пустими або від'ємними", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.OpenConnection();
                    try
                    {
                        string query = "INSERT INTO intermediateroute (RouteId, NameStation, DistanceFromStart, DistanceToEnd, ArrivalTime) VALUES (@RouteId, @NameStation, @DistanceFromStart, @DistanceToEnd, @ArrivalTime)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@RouteId", int.Parse(Routeid.selectedValue));
                            cmd.Parameters.AddWithValue("@NameStation", NameTransportTextBox.Text);
                            cmd.Parameters.AddWithValue("@DistanceFromStart", int.Parse(DistanceFromStart.Text));
                            cmd.Parameters.AddWithValue("@DistanceToEnd", int.Parse(DistanceToEnd.Text));
                            cmd.Parameters.AddWithValue("@ArrivalTime", DateTime.Parse(ArrivalTime.Value.ToString()));

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Дані успішно додано");
                        MessageBox.Show("Дані успішно додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("При додаванні даних у таблицю intermediateroute виникла помилка");
                        Console.WriteLine($"Помилка: {ex.Message}");
                        MessageBox.Show("Дані не були додані до бази даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    { 
                        db.CloseConnection(); 
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевненні, що хочете видалення цю інформацію?", "Видалення інформації",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                try
                {
                    db.OpenConnection();
                    string query = "DELETE FROM intermediateroute WHERE NameStation = @NameStation";

                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@NameStation", NameStationDelete.Text);

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Видалення відбулося успішно");
                    MessageBox.Show("Видалення відбулося успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("При видаленні даних з таблиці intermediateroute виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("При видаленні даних з таблиці intermediateroute виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
