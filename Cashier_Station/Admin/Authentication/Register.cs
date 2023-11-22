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
                Console.WriteLine($"При зчитуванні кодового слова виникла помилка: {ex.Message}");
                MessageBox.Show("При зчитуванні кодового слова виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
                            string query = "INSERT INTO workers (login, password) VALUES (@login, @pass)";
                            for (int i = 0; i < lines.Length; i += 2)
                            {
                                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                                {

                                    string login = lines[i];
                                    string password = lines[i + 1];

                                    cmd.Parameters.AddWithValue("@login", login);
                                    cmd.Parameters.AddWithValue("@pass", password);

                                    cmd.ExecuteNonQuery();
                                }
                            }
                            Console.WriteLine("Дані успішно відправлені у базу даних");
                            MessageBox.Show("Створення облікових записів успішне", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"При записі даних у базу даних виникла помикла: {ex.Message}");
                            MessageBox.Show("При записі даних у базу даних виникла помикла", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            db.CloseConnection();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"При відкритті файлу виникла помикла: {ex.Message}");
                    MessageBox.Show("При відкритті файлу виникла помикла", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Кодові слова не співпадають\nДоступ заборонений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
            
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            mainWindow.OpenInWindow(new Login(mainWindow));
        }
    }
}
