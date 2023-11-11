using Cashier_Station.Admin;
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

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            var addroute = new AdminAddRouteWindow();
            addroute.ShowDialog();
        }

        private void DeleteTicketButton_Click(object sender, EventArgs e)
        {
            var deleteTicket = new AdminDeleteTicketWindow();
            deleteTicket.ShowDialog();
        }

        private void DeleteRouteButton_Click(object sender, EventArgs e)
        {
            var deleteRoute = new AdminDeleteRouteWindow();
            deleteRoute.ShowDialog();
        }

        private void EditRouteButton_Click(object sender, EventArgs e)
        {
            var editroute = new AdminEditRouteWindow();
            editroute.ShowDialog();
        }

        private void EditTicketButton_Click(object sender, EventArgs e)
        {
            var editticket = new AdminTicketEditWindow();
            editticket.ShowDialog();
        }

        private void AddtransportButton_Click(object sender, EventArgs e)
        {
            var addTransp = new AddTransportWindow();
            addTransp.ShowDialog();
        }

        private void EditTransportButton_Click(object sender, EventArgs e)
        {
            var edittransp = new EditTransportWindow();
            edittransp.ShowDialog();
        }

        private void DeleteTransportButton_Click(object sender, EventArgs e)
        {
            var deletetransp = new DeleteTransportWindow();
            deletetransp.ShowDialog();
        }
    }
}
