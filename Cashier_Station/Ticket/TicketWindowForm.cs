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

                TicketGridView.Columns[0].HeaderText = "Route number";
                TicketGridView.Columns[1].HeaderText = "Point of departure";
                TicketGridView.Columns[2].HeaderText = "Point of arrival";
                TicketGridView.Columns[3].HeaderText = "Date of departure";
                TicketGridView.Columns[4].HeaderText = "Date of arrival";
                TicketGridView.Columns[5].HeaderText = "Number of seats";
                TicketGridView.Columns[6].HeaderText = "Transport number";

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

                TicketGridView.Columns[0].HeaderText = "Route number";
                TicketGridView.Columns[1].HeaderText = "Point of departure";
                TicketGridView.Columns[2].HeaderText = "Point of arrival";
                TicketGridView.Columns[3].HeaderText = "Date of departure";
                TicketGridView.Columns[4].HeaderText = "Date of arrival";
                TicketGridView.Columns[5].HeaderText = "Number of seats";
                TicketGridView.Columns[6].HeaderText = "Transport number";
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
    }
}
