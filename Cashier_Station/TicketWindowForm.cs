using Cashier_Station.Models;
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
    public partial class TicketWindowForm : Form
    {
        public TicketWindowForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ticketbuy = new BuyTicketAuthorization();
            ticketbuy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ticketreturn = new ReturnTicketWindow();
            ticketreturn.Show();
        }
    }
}
