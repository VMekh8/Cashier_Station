using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;


using System.Windows.Forms;

namespace Cashier_Station.Admin
{
    public partial class DeleteTransportWindow : Form
    {
        DataBase db = new DataBase();
        public DeleteTransportWindow()
        {
            InitializeComponent();
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
                MessageBox.Show("При завантаженні даних з бази даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            foreach (var item in routeid)
            {
                IdtransportDelete.AddItem(item.ToString());
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевненні, що хочете видалення цю інформацію?", "Видалення інформації",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {


                try
                {
                    db.OpenConnection();
                    string query = "DELETE FROM transport WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(IdtransportDelete.selectedValue));

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Видалення відбулося успішно");
                    MessageBox.Show("Видалення відбулося успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("При видаленні даних з таблиці transport виникла помилка");
                    Console.WriteLine($"Помилка: {ex.Message}");
                    MessageBox.Show("При видаленні даних з таблиці transport виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
