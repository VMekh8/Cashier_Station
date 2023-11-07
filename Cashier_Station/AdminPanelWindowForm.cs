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
    public partial class AdminPanelWindowForm : Form
    {
        public AdminPanelWindowForm()
        {
            InitializeComponent();
        }

        private void AddTicketButton_Click(object sender, EventArgs e)
        {
            var addticket = new AdminAddTicketWindow();
            addticket.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addroute = new AdminAddRouteWindow();
            addroute.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var deleteTicket = new AdminDeleteTicketWindow();
            deleteTicket.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var deleteRoute = new AdminDeleteRouteWindow();
            deleteRoute.ShowDialog();
        }
    }
}
