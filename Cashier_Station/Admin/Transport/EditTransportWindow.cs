using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Station.Admin
{
    public partial class EditTransportWindow : Form
    {
        DataBase db = new DataBase();
        public EditTransportWindow()
        {
            InitializeComponent();
            FillDataGrid();
            FillDropDown();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDropDown()
        {
            List<string> routeid = new List<string>();
            try
            {
                db.OpenConnection();
                string query = "SELECT id FROM transport";

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
                TransportIdDropDown.AddItem(item.ToString());
            }
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM transport";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection()))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    TransportGridView.DataSource = ds.Tables[0];
                }
                TransportGridView.Columns[0].HeaderText = "Transport number";
                TransportGridView.Columns[1].HeaderText = "Name of transport";
                

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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to send this information?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db.OpenConnection();
                    string query = "UPDATE transport SET Name = @Name WHERE id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Name", NameTransportTextBox.Text);
                        cmd.Parameters.AddWithValue("@id", int.Parse(TransportIdDropDown.selectedValue));

                        cmd.ExecuteNonQuery();
                    }
                    Console.WriteLine("Data has been successfully sent");
                    MessageBox.Show("Data has been successfully sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                

        private void TransportIdDropDown_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM transport WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(TransportIdDropDown.selectedValue));

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        NameTransportTextBox.Text = reader["Name"].ToString();
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
    }
}
