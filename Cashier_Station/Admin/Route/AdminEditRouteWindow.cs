using Bunifu.Framework.UI;
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
    public partial class AdminEditRouteWindow : Form
    {
        DataBase db = new DataBase();
        public AdminEditRouteWindow()
        {
            InitializeComponent();
            FillDataGrid();
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

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM route";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection()))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    RouteGridView.DataSource = ds.Tables[0];
                }

                RouteGridView.Columns[0].HeaderText = "Route number";
                RouteGridView.Columns[1].HeaderText = "Point of departure";
                RouteGridView.Columns[2].HeaderText = "Point of arrival";
                RouteGridView.Columns[3].HeaderText = "Date of departure";
                RouteGridView.Columns[4].HeaderText = "Date of arrival";
                RouteGridView.Columns[5].HeaderText = "Number of seats";
                RouteGridView.Columns[6].HeaderText = "Transport number";

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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdRouteDropDown_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM route WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(IdRouteDropDown.selectedValue));

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        StartPoint.Text = reader["StartPoint"].ToString();
                        EndPoint.Text = reader["EndPoint"].ToString();
                        DateStart.Value = DateTime.Parse(reader["DateofStart"].ToString());
                        DateArrival.Value = DateTime.Parse(reader["DateofEnd"].ToString());
                        SeatsNumber.Text = reader["SeatsNumber"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred when selecting data");
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while uploading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to send this information?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.OpenConnection();
                    string query = "UPDATE route SET StartPoint = @StartPoint, EndPoint = @EndPoint, DateofStart = @DateofStart, DateofEnd = @DateofEnd, SeatsNumber = @SeatsNumber WHERE id = @id";
                    DateTime dateOfStart = DateTime.Parse(DateStart.Value.ToString());
                    DateTime dateOfEnd = DateTime.Parse(DateArrival.Value.ToString());

                    if (dateOfStart.Date <= DateTime.Now.Date || dateOfEnd.Date <= DateTime.Now.Date || dateOfStart.Date >= dateOfEnd.Date)
                    {
                        MessageBox.Show("Invalid date selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@StartPoint", StartPoint.Text);
                            cmd.Parameters.AddWithValue("@EndPoint", EndPoint.Text);
                            cmd.Parameters.AddWithValue("@DateofStart", DateTime.Parse(DateStart.Value.ToString()));
                            cmd.Parameters.AddWithValue("@DateofEnd", DateTime.Parse(DateArrival.Value.ToString()));
                            cmd.Parameters.AddWithValue("@SeatsNumber", int.Parse(SeatsNumber.Text));


                            cmd.Parameters.AddWithValue("@id", int.Parse(IdRouteDropDown.selectedValue));

                            cmd.ExecuteNonQuery();

                        }

                        Console.WriteLine("Data has been successfully sent");
                        MessageBox.Show("Data has been successfully sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while editing data");
                    Console.WriteLine(ex.Message.ToString());
                    MessageBox.Show("An error occurred while editing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                { 
                    db.CloseConnection();
                    FillDataGrid();
                }
            }
        }
    }
}
