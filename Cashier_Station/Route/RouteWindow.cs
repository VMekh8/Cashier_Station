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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var frequency = new FrequencyWindowForm();
            frequency.ShowDialog();
        }
    }
}
