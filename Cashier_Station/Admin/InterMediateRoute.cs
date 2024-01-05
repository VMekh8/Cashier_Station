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
            FillDropDownRoute();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDropDownRoute()
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
                MessageBox.Show("An error occurred while loading data from the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
            var result = MessageBox.Show("Are you sure you want to add this information?", "Adding information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (NameTransportTextBox.Text == "" || DistanceFromStart.Text == "" || DistanceToEnd.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.OpenConnection();
                    try
                    {
                        intermediateroute newIntermediateroute = new intermediateroute
                        {
                            RouteId = int.Parse(Routeid.selectedValue),
                            NameStation = NameTransportTextBox.Text,
                            DistanceFromStart = double.Parse(DistanceFromStart.Text),
                            DistanceToEnd = double.Parse(DistanceToEnd.Text),
                            ArrivalTime = DateTime.Parse(ArrivalTime.Value.ToString())
                        };
                        string query = "INSERT INTO intermediateroute (RouteId, NameStation, DistanceFromStart, DistanceToEnd, ArrivalTime) VALUES (@RouteId, @NameStation, @DistanceFromStart, @DistanceToEnd, @ArrivalTime)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@RouteId", newIntermediateroute.RouteId);
                            cmd.Parameters.AddWithValue("@NameStation", newIntermediateroute.NameStation);
                            cmd.Parameters.AddWithValue("@DistanceFromStart", newIntermediateroute.DistanceFromStart);
                            cmd.Parameters.AddWithValue("@DistanceToEnd", newIntermediateroute.DistanceToEnd);
                            cmd.Parameters.AddWithValue("@ArrivalTime", newIntermediateroute.ArrivalTime);

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Data added successfully");
                        MessageBox.Show("Data added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while adding data to the 'intermediateroute' table");
                        Console.WriteLine($"Error: {ex.Message}");
                        MessageBox.Show("Data has not been added to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var result = MessageBox.Show("Are you sure you want to delete this information?", "Deleting information",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                try
                {
                    db.OpenConnection();
                    string checkQuery = "SELECT COUNT(*) FROM intermediateroute WHERE NameStation = @NameStation";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.GetConnection()))
                    {
                        checkCmd.Parameters.AddWithValue("@NameStation", StationNameDel.selectedValue);

                        int rowCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (rowCount > 0)
                        {
                            // Запис існує, тепер можна видалити
                            string deleteQuery = "DELETE FROM intermediateroute WHERE NameStation = @NameStation";

                            using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, db.GetConnection()))
                            {
                                deleteCmd.Parameters.AddWithValue("@NameStation", StationNameDel.selectedValue);

                                deleteCmd.ExecuteNonQuery();
                            }

                            Console.WriteLine("The removal was successful");
                            MessageBox.Show("The removal was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Запис не існує, вивести відповідне повідомлення
                            MessageBox.Show("Record not found. Nothing was deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while deleting data from the 'intermediateroute' table");
                    Console.WriteLine($"Error: {ex.Message}");
                    MessageBox.Show("An error occurred while deleting data from the 'intermediateroute' table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void RouteIdDelete_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();

                string query = "SELECT NameStation FROM intermediateroute WHERE RouteId = @RouteId";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@RouteId", RouteIdDelete.selectedValue);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        StationNameDel.Clear();

                        while (reader.Read())
                        {
                            string stationName = reader["NameStation"].ToString();
                            StationNameDel.AddItem(stationName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while loading intermediate stations");
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show("An error occurred while loading intermediate stations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
