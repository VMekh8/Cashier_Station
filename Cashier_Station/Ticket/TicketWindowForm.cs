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
    public partial class TicketWindowForm : Form
    {
        DataBase db = new DataBase();
        public TicketWindowForm()
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
                    TicketGridView.DataSource = ds.Tables[0];
                }

                TicketGridView.Columns[0].HeaderText = "Номер маршруту";
                TicketGridView.Columns[1].HeaderText = "Точка відправлення";
                TicketGridView.Columns[2].HeaderText = "Точка прибуття";
                TicketGridView.Columns[3].HeaderText = "Дата відправлення";
                TicketGridView.Columns[4].HeaderText = "Дата прибуття";
                TicketGridView.Columns[5].HeaderText = "Кількість місць";
                TicketGridView.Columns[6].HeaderText = "Номер транспорту";

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


        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            var ticketbuy = new BuyTicketAuthorization();
            ticketbuy.ShowDialog();
        }

        private void ReturnTicketButton_Click(object sender, EventArgs e)
        {
            var ticketreturn = new ReturnTicketWindow();
            ticketreturn.ShowDialog();
        }

        private void FindSeatButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM route WHERE id = @id AND SeatsNumber > 0";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(RouteIdForTicket.Text)); 
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        TicketGridView.DataSource = ds.Tables[0];
                    }
                }

                TicketGridView.Columns[0].HeaderText = "Номер маршруту";
                TicketGridView.Columns[1].HeaderText = "Точка відправлення";
                TicketGridView.Columns[2].HeaderText = "Точка прибуття";
                TicketGridView.Columns[3].HeaderText = "Дата відправлення";
                TicketGridView.Columns[4].HeaderText = "Дата прибуття";
                TicketGridView.Columns[5].HeaderText = "Кількість місць";
                TicketGridView.Columns[6].HeaderText = "Номер транспорту";
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
