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
using System.Xml.Schema;

namespace Cashier_Station
{
    public partial class ReturnTicketWindow : Form
    {
        DataBase db = new DataBase();
        List<string> ticketid = new List<string>();
        List<string> routeid = new List<string>();
        public ReturnTicketWindow()
        {
            InitializeComponent();
            FillDropDown();
        }

        private void FillDropDown()
        {
            
            try
            {
                db.OpenConnection();
                string query = "SELECT id, RouteId FROM ticket WHERE IsActive = true";

                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ticketid.Add(reader["id"].ToString());
                        routeid.Add(reader["RouteId"].ToString());
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

            foreach (var item in ticketid)
            {
                TicketNumberDropDown.AddItem(item.ToString());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете повернути цей квиток?", "Повернення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {  
                try
                {
                    db.OpenConnection();
                    string query = "START TRANSACTION;" +
                        "UPDATE route SET SeatsNumber = SeatsNumber + 1 WHERE id = @RouteId;" +
                        "UPDATE ticket SET isActive = false WHERE id = @TicketId;" +
                        "DELETE FROM client WHERE TicketId = @TicketId;" +
                        "COMMIT;";


                    using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@TicketId", ticketid[TicketNumberDropDown.selectedIndex]);
                        cmd.Parameters.AddWithValue("@RouteId", routeid[TicketNumberDropDown.selectedIndex]);

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Дані успішно відправлені");
                    MessageBox.Show("Ваш квиток повернено!\nГроші невдовзі повернуться на ваш рахунок", "Повернення квитків", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("При завантаженні даних виникла помилка");
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("При завантаженні даних виникла помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
