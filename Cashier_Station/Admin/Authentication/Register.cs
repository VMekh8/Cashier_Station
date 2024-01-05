using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Station.Admin.Authentication
{
    public partial class Register : Form
    {
        MainWindow mainWindow;
        DataBase db = new DataBase();
        public Register(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private string GetKeyWord()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT word FROM keyword";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())

                        if (reader.Read())
                        {
                            return reader["word"].ToString();
                        }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading a code word: {ex.Message}");
                MessageBox.Show("An error occurred while reading a code word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                db.CloseConnection();
            }
            return string.Empty;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Equals(GetKeyWord()))
            {
                try
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    string filePath;
                    string[] lines;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        lines = File.ReadAllLines(filePath);

                        try
                        {
                            db.OpenConnection();
                            string queryCheckExistence = "SELECT COUNT(*) FROM workers WHERE login = @login";
                            string query = "INSERT INTO workers (login, password) VALUES (@login, @pass)";
                            bool isExist=false;
                            for (int i = 0; i < lines.Length; i += 2)
                            {
                                string login = lines[i];
                                string password = lines[i + 1];

                                using (MySqlCommand checkCmd = new MySqlCommand(queryCheckExistence, db.GetConnection()))
                                {
                                    checkCmd.Parameters.AddWithValue("@login", login);
                                    int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                                    if (existingCount > 0)
                                    {
                                        // The login already exists, handle accordingly (e.g., skip, show error message)
                                        Console.WriteLine($"Login '{login}' already exists. Skipping insertion.");
                                        MessageBox.Show($"Login '{login}' already exists. Skipping insertion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        isExist = true;
                                        continue;
                                    }
                                }

                                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                                {
                                    cmd.Parameters.AddWithValue("@login", login);
                                    cmd.Parameters.AddWithValue("@pass", password);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                            if (isExist)
                            {
                                Console.WriteLine($"Login already exists. Skipping insertion.");
                                MessageBox.Show("Some logins already exist. Change them for successful registration.\nAccount creation is successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Console.WriteLine("Data successfully sent to the database");
                                MessageBox.Show("Account creation is successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred while writing data to the database: {ex.Message}");
                            MessageBox.Show("An error occurred while writing data to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            db.CloseConnection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred when opening a file: {ex.Message}");
                    MessageBox.Show("An error occurred when opening a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Code words do not match\nAccess denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
            
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            mainWindow.OpenInWindow(new Login(mainWindow));
        }
    }
}
