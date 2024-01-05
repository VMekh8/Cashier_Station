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
    public partial class CashierMainWindow : Form
    {
        DataBase db = new DataBase();
        public CashierMainWindow()
        {
            InitializeComponent();
            FillDataGrid();
            CountIcnomes();
        }

        private void CountIcnomes()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT SUM(Price) as TotalPrice, COUNT(*) as TotalTickets FROM ticket WHERE isActive = true";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                   if(reader.Read()) 
                   { 
                        decimal totalprice = reader.GetDecimal("TotalPrice");
                        int ticketcount = reader.GetInt32("TotalTickets");

                        label3.Text = totalprice.ToString() + " UAH";
                        label4.Text = ticketcount.ToString();
                   }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There are no tickets sold", "Calculating the cost", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "SELECT * FROM ticket";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection()))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    TicketGridView.DataSource = ds.Tables[0];
                }
                TicketGridView.Columns[1].HeaderText = "Route id";
                TicketGridView.Columns[2].HeaderText = "Cost";
                TicketGridView.Columns[3].HeaderText = "Date of purchase";
                TicketGridView.Columns[4].HeaderText = "Active or not?";

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
