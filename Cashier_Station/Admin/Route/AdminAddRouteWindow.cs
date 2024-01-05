using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cashier_Station
{
    public partial class AdminAddRouteWindow : Form
    {
        DataBase db = new DataBase();
        public AdminAddRouteWindow()
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
                string query = "SELECT id FROM transport";

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
                TransportIdDropDown.AddItem(item.ToString());
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to add this information??", "Adding information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db = new DataBase();
                try
                {
                    if (NumberRoute.Text == "" || StartPoint.Text == "" || EndPoint.Text == "" 
                        || TransportIdDropDown.selectedValue == "" || SeatsNumber.Text == "")
                    {
                        MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DateTime dateOfStart = DateTime.Parse(bunifuDatepicker1.Value.ToString());
                        DateTime dateOfEnd = DateTime.Parse(bunifuDatepicker2.Value.ToString());

                        if (dateOfStart.Date <= DateTime.Now.Date || dateOfEnd.Date <= DateTime.Now.Date || dateOfStart.Date >= dateOfEnd.Date)
                        {
                            MessageBox.Show("Invalid date selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            db.OpenConnection();

                            Route newRoute = new Route
                            {
                                Id = int.Parse(NumberRoute.Text),
                                StartPoint = StartPoint.Text,
                                EndPoint = EndPoint.Text,
                                DateOfStart = DateTime.Parse(bunifuDatepicker1.Value.ToString()),
                                DateOfEnd = DateTime.Parse(bunifuDatepicker2.Value.ToString()),
                                SeatsNumber = int.Parse(SeatsNumber.Text),
                                TransportId = int.Parse(TransportIdDropDown.selectedValue)
                            };

                            string query = "INSERT INTO route (id, StartPoint, EndPoint, DateofStart, DateofEnd, SeatsNumber, TransportId) VALUES (@id, @StartPoint, @EndPoint, @DateofStart, @DateofEnd, @SeatsNumber, @TransportId)";

                            using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@id", newRoute.Id);
                                cmd.Parameters.AddWithValue("@StartPoint", newRoute.StartPoint);
                                cmd.Parameters.AddWithValue("@EndPoint", newRoute.EndPoint);
                                cmd.Parameters.AddWithValue("@DateofStart", newRoute.DateOfStart);
                                cmd.Parameters.AddWithValue("@DateofEnd", newRoute.DateOfEnd);
                                cmd.Parameters.AddWithValue("@SeatsNumber", newRoute.SeatsNumber);
                                cmd.Parameters.AddWithValue("@TransportId", newRoute.TransportId);

                                cmd.ExecuteNonQuery();
                            }

                            Console.Write("Data successfully added to the database");
                            MessageBox.Show("Data successfully added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while adding data to the route table");
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
