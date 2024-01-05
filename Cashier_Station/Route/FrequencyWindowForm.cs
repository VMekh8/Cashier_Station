using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Station
{
    public partial class FrequencyWindowForm : Form
    {
        DataBase db = new DataBase();
        public FrequencyWindowForm()
        {
            InitializeComponent();
            FillDataGrid();
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnalyseButton_Click(object sender, EventArgs e)
        {
            try
            {

                string queryString = @"
                    SELECT 
                route.*,
                intermediateroute.NameStation,
                intermediateroute.DistanceFromStart,
                intermediateroute.DistanceToEnd
            FROM 
                route
            LEFT JOIN 
                intermediateroute ON route.id = intermediateroute.RouteId
            WHERE 
                (StartPoint = @StartPoint AND EndPoint = @EndPoint)
                OR (StartPoint = @StartPoint AND intermediateroute.NameStation IS NOT NULL)
                OR (intermediateroute.NameStation = @StartPoint AND EndPoint = @EndPoint)
            ORDER BY 
                DateofStart ASC;";

                using (MySqlCommand command = new MySqlCommand(queryString, db.GetConnection()))
                {

                    command.Parameters.AddWithValue("@StartPoint", StartPointTextBox.Text);
                    command.Parameters.AddWithValue("@EndPoint", EndPointTextBox.Text);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);

                    RouteGridView.DataSource = table;

                    if (table.Rows.Count > 0)
                    {
                        DataRow firstRow = table.Rows[0];
                        MessageBox.Show($"The nearest train runs on this route: {firstRow["DateofStart"].ToString()}", "Analysis of routes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No trains available.");
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
    }
}
