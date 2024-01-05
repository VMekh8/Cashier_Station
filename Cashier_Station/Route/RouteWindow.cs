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
    public partial class RouteWindow : Form
    {
        DataBase db = new DataBase();
        public RouteWindow()
        {
            InitializeComponent();
            FillDataGrid();
            GetLongestRoute();
        }

        private void GetLongestRoute()
        {

            try
            {
                db.OpenConnection();
                string query = @"
                SELECT 
                    intermediateroute.DistanceFromStart + intermediateroute.DistanceToEnd AS TotalDistance, 
                    route.StartPoint, 
                    route.EndPoint 
                FROM 
                    intermediateroute 
                INNER JOIN 
                    route ON intermediateroute.RouteId = route.id 
                ORDER BY 
                    TotalDistance DESC
                LIMIT 1;";


                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    decimal maxDistance;
                    string endPoint, startPoint;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maxDistance = reader.GetDecimal("TotalDistance");
                            startPoint = reader.GetString("StartPoint");
                            endPoint = reader.GetString("EndPoint");


                            LongestRouteName.Text = $"{startPoint} - {endPoint}";
                            LongestRouteRange.Text = $"{maxDistance} км.";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while uploading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
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
            var frequency = new FrequencyWindowForm();
            frequency.ShowDialog();
        }
    }
}
