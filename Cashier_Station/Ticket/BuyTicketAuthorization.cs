using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
                string query = "SELECT * FROM ticket WHERE IsActive = false";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tickets.Add($"Ticket number: {reader["id"].ToString()} Route number: {reader["RouteId"].ToString()} Cost: {reader["Price"].ToString()}");
                        ticketid.Add(int.Parse(reader["id"].ToString()));
                        routeid.Add(int.Parse(reader["RouteId"].ToString()));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data from the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var result = MessageBox.Show("Are you sure you want to buy this ticket?", "Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (UsrnameTextBox.Text == "" || SurnameTextBox.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty", "Purchase tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        client newClient = new client
                        {
                            Name = UsrnameTextBox.Text,
                            Surname = SurnameTextBox.Text,
                            TicketId = ticketid[IdTicket.selectedIndex]
                        };
                        db.OpenConnection();
                        string query = "START TRANSACTION;" +
                            "INSERT INTO client (Name, Surname, TicketId) VALUES (@Name, @Surname, @TicketId);" +
                            "UPDATE route SET SeatsNumber = SeatsNumber - 1 WHERE id = @RouteId;" +
                            "UPDATE ticket SET isActive = true, DateBuy = @DateBuy WHERE id = @TicketId;" +
                            "COMMIT;";


                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@Name", newClient.Name);
                            cmd.Parameters.AddWithValue("@Surname", newClient.Surname);
                            cmd.Parameters.AddWithValue("@TicketId", newClient.TicketId);
                            cmd.Parameters.AddWithValue("@RouteId", routeid[IdTicket.selectedIndex]);
                            cmd.Parameters.AddWithValue("@DateBuy", DateTime.Now);

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Data has been successfully sent");
                        MessageBox.Show("Data has been successfully sent\nThank you!", "Purchase tickets", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while uploading data");
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("An error occurred while uploading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
