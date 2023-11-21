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
    public partial class AdminDeleteTicketWindow : Form
    {
        DataBase db = new DataBase();
        public AdminDeleteTicketWindow()
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
                IdTicket.AddItem(item.ToString());
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
