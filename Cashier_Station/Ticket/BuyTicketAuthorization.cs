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

namespace Cashier_Station.Models
{
    public partial class BuyTicketAuthorization : Form
    {
        DataBase db = new DataBase();
        List<int> ticketid = new List<int>();
        List<int> routeid = new List<int>();
        public BuyTicketAuthorization()
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
            List<string> tickets = new List<string>();
           
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM ticket";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tickets.Add($"Номер квитка: {reader["id"].ToString()} Номер маршруту: {reader["RouteId"].ToString()} Вартість: {reader["Price"].ToString()}");
                        ticketid.Add(int.Parse(reader["id"].ToString()));
                        routeid.Add(int.Parse(reader["RouteId"].ToString()));
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

            foreach (var item in tickets)
            {
                IdTicket.AddItem(item.ToString());
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете придбати цей квиток?", "Покупка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.OpenConnection();
                    string query = "START TRANSACTION;" +
                        "INSERT INTO client (Name, Surname, TicketId) VALUES (@Name, @Surname, @TicketId);" +
                        "UPDATE route SET SeatsNumber = SeatsNumber - 1 WHERE id = @RouteId;" +
                        "COMMIT;";


                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Name", UsrnameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Surname", SurnameTextBox.Text);
                        cmd.Parameters.AddWithValue("@TicketId", ticketid[IdTicket.selectedIndex]);
                        cmd.Parameters.AddWithValue("@RouteId", routeid[IdTicket.selectedIndex]);

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Дані успішно відправлені");
                    MessageBox.Show("Дані успішно відправлені\nДякуємо!", "Покупка квитків", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("При завантаженні даних виникла помилка");
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("При завантаженні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    db.CloseConnection();
                }
            }
        }
    }
}
