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
        DataBase db = new DataBase();
        
        public AdminAddTicketWindow()
        {
            InitializeComponent();
            FillDropDown();
        }

        private void FillDropDown()
        {
            List<string> routeid = new List<string>();
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM route";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
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
                MessageBox.Show("An error occurred while loading data from the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            foreach (var item in routeid)
            {
                IdRouteDropDown.AddItem(item.ToString());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to add this information?", "Adding information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {


                    db = new DataBase();
                    if (IdTicketTextBox.Text == "" || PriceTicketTextBox.Text == "" || IdRouteDropDown.selectedValue == "")
                    {
                        MessageBox.Show("Fields cannot be empty or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Ticket newTicket = new Ticket
                        {
                            Id = int.Parse(IdTicketTextBox.Text),
                            RouteId = int.Parse(IdRouteDropDown.selectedValue),
                            Price = Convert.ToDecimal(PriceTicketTextBox.Text),
                            IsActive = false
                        };

                        db.OpenConnection();
                        string query = "INSERT INTO ticket (id, RouteId, Price, IsActive) VAlUES (@id, @RouteId, @Price, @IsActive)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {

                            cmd.Parameters.AddWithValue("@id", newTicket.Id);
                            cmd.Parameters.AddWithValue("@RouteId", newTicket.RouteId);
                            cmd.Parameters.AddWithValue("@Price", newTicket.Price);
                            cmd.Parameters.AddWithValue("@IsActive", newTicket.IsActive);


                            cmd.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Data added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show("Data has not been added to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    db.CloseConnection();
                }

            }

        }
    }
}
