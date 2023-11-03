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
    public partial class MainWindow : Form
    {
        UIClass uI = new UIClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gray;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            uI.OpenInWindow(new BuyTicketAuthorization(), PanelWindow);
        }
    }
}
