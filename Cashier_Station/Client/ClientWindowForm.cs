﻿using MySql.Data.MySqlClient;
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
    public partial class ClientWindowForm : Form
    {
        DataBase db = new DataBase();
        public ClientWindowForm()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM  client";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection()))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ClientDataGrid.DataSource = ds.Tables[0];
                }

                ClientDataGrid.Columns[0].HeaderText = "Customer number";
                ClientDataGrid.Columns[1].HeaderText = "Name";
                ClientDataGrid.Columns[2].HeaderText = "Surname";
                ClientDataGrid.Columns[3].HeaderText = "Ticket number";
               

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

        private void ClientInfoButton_Click(object sender, EventArgs e) => FillDataGrid();

        private void FindBySurButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM client WHERE Surname = @surname";
                using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@surname", SurNameTextBox.Text);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        ClientDataGrid.DataSource = ds.Tables[0];
                    }
                }

                ClientDataGrid.Columns[0].HeaderText = "Customer number";
                ClientDataGrid.Columns[1].HeaderText = "Name";
                ClientDataGrid.Columns[2].HeaderText = "Surname";
                ClientDataGrid.Columns[3].HeaderText = "Ticket number";
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while uploading data");
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred while uploading data", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
