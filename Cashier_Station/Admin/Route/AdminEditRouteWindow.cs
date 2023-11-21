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
                MessageBox.Show("При завантаженні даних з бази даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Console.WriteLine("Виникла помилка при вибірці даних");
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
            var result = MessageBox.Show("Ви впевнені, що хочете відправити цю інформацію?", "Редагування", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.OpenConnection();
                    string query = "UPDATE route SET StartPoint = @StartPoint, EndPoint = @EndPoint, DateofStart = @DateofStart, DateofEnd = @DateofEnd, SeatsNumber = @SeatsNumber WHERE id = @id";

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

                    Console.WriteLine("Дані успішно відправлені");
                    MessageBox.Show("Дані успішно відправленні", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("При редагуванні даних виникла помилка");
                    Console.WriteLine(ex.Message.ToString());
                    MessageBox.Show("При редагуванні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
