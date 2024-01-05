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
    public partial class AdminTicketEditWindow : Form
    {
        DataBase db = new DataBase();
        public AdminTicketEditWindow()
        {
            InitializeComponent();
            FillDataGrid();
            FillDropDownTicket();
            FillDropDownRoute();
        }


        private void FillDropDownTicket()
        {
            List<string> routeid = new List<string>();
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM ticket";

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
                IdTicketDropDown.AddItem(item.ToString());
            }
        }

        private void FillDropDownRoute()
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


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdRouteDropDown.selectedValue == "" || TicketPriceTextBox.Text == "")
                {
                    var result = MessageBox.Show("You have not filled in all the fields, do you want to edit this record?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Then fill in all the fields", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    try
                    {
                        db.OpenConnection();
                        string query = "UPDATE ticket SET RouteId = @RouteId, Price = @Price WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@RouteId", int.Parse(IdRouteDropDown.selectedValue));
                            cmd.Parameters.AddWithValue("@Price", double.Parse(TicketPriceTextBox.Text));
                            cmd.Parameters.AddWithValue("@id", int.Parse(IdTicketDropDown.selectedValue));

                            cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Changes have been successfully implemented");
                        MessageBox.Show("Changes have been successfully implemented", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while editing data");
                        Console.WriteLine(ex.Message.ToString());
                        MessageBox.Show("An error occurred while editing data", "Уккщу", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        db.CloseConnection();
                        FillDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while editing data");
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("An error occurred while editing data", "Уккщу", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
