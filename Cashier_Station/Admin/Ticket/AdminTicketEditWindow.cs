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
            FillDropDown();
        }


        private void FillDropDown()
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
                MessageBox.Show("При завантаженні даних з бази даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                TicketGridView.Columns[1].HeaderText = "Id маршруту";
                TicketGridView.Columns[2].HeaderText = "Вартість";
                TicketGridView.Columns[3].HeaderText = "Дата покупки";
                TicketGridView.Columns[4].HeaderText = "Чи активний?";

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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (RouteNumberTextBox.Text == "" || TicketPriceTextBox.Text == "")
            {
                var result = MessageBox.Show("Ви не заповнили всі поля, чи бажаєте ви редагувати цей запис?", "Редагування", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Тоді заповність всі поля", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd.Parameters.AddWithValue("@RouteId", int.Parse(RouteNumberTextBox.Text));
                        cmd.Parameters.AddWithValue("@Price", int.Parse(TicketPriceTextBox.Text));
                        cmd.Parameters.AddWithValue("@id", int.Parse(IdTicketDropDown.selectedValue));

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Зміни успішно внесені");
                    MessageBox.Show("Зміни успішно внесені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
