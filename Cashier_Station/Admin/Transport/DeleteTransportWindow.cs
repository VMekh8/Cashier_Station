using System;
using System.Data;


using System.Windows.Forms;

namespace Cashier_Station.Admin
{
    public partial class DeleteTransportWindow : Form
    {
        DataBase db;
        DataTable dataTable = new DataTable();
        public DeleteTransportWindow()
        {
            InitializeComponent();
        }


        private void FillDropDown()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
