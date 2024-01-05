using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Cashier_Station.Admin
{
    public partial class AddTransportWindow : Form
    {
        DataBase db;
        public AddTransportWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var DialogRes = MessageBox.Show("Do you really want to add this information?", "Adding information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogRes  == DialogResult.Yes)
            {
                if (IdTrasportTextBox.Text == "" || NameTransportTextBox.Text == "" || int.Parse(IdTrasportTextBox.Text) <= 0)
                {
                    MessageBox.Show("Fields cannot be empty or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    try
                    {
                        db = new DataBase();
                        db.OpenConnection();

                        Transport newTransport = new Transport
                        {
                            Id = int.Parse(IdTrasportTextBox.Text),
                            Name = NameTransportTextBox.Text.ToString()
                        };

                        string query = "INSERT INTO transport (id, name) VALUES (@id, @name)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", newTransport.Id);
                            cmd.Parameters.AddWithValue("@name", newTransport.Name);

                            cmd.ExecuteNonQuery();
                        }
                        Console.WriteLine("Data added successfully");
                        MessageBox.Show("Data added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while adding data to the 'transport' table");
                        Console.WriteLine($"Помилка: {ex.Message}");
                        MessageBox.Show("Data has not been added to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                }
            }
        }
    }
}
