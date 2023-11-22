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

                RouteGridView.Columns[0].HeaderText = "Номер маршруту";
                RouteGridView.Columns[1].HeaderText = "Точка відправлення";
                RouteGridView.Columns[2].HeaderText = "Точка прибуття";
                RouteGridView.Columns[3].HeaderText = "Дата відправлення";
                RouteGridView.Columns[4].HeaderText = "Дата прибуття";
                RouteGridView.Columns[5].HeaderText = "Кількість місць";
                RouteGridView.Columns[6].HeaderText = "Номер транспорту";

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnalyseButton_Click(object sender, EventArgs e)
        {
            try
            {

                string queryString = @"
                    SELECT * 
                    FROM route
                    WHERE StartPoint = @StartPoint AND EndPoint = @EndPoint
                    ORDER BY DateofStart ASC;";

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
                        MessageBox.Show($"Найближчий потяг вирушає цим маршрутом: {firstRow["DateofStart"].ToString()}", "Аналіз маршрутів", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Немає доступних потягів.");
                    }

                }
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
