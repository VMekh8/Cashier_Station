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
        
        public MainWindow()
        {
            InitializeComponent();
            OpenInWindow(new MainWindowForm(this));
        }


        public void OpenInWindow(Form fm)
        {
            var p = GetMainPanel();
            fm.TopLevel = false;
            fm.TopMost = true;
            fm.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Clear();
            p.Controls.Add(fm);
            fm.Visible = true;
        }

        public Panel GetMainPanel() => this.PanelWindow;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainlabel_MouseHover(object sender, EventArgs e)
        {
            Mainlabel.ForeColor = Color.Gray;
        }

        private void Mainlabel_MouseLeave(object sender, EventArgs e)
        {
            Mainlabel.ForeColor = Color.White;

        }

        private void CashierLabel_MouseHover(object sender, EventArgs e)
        {
            CashierLabel.ForeColor = Color.Gray;

        }

        private void CashierLabel_MouseLeave(object sender, EventArgs e)
        {
            CashierLabel.ForeColor = Color.White;

        }

        private void AdminLabel_MouseHover(object sender, EventArgs e)
        {
            AdminLabel.ForeColor = Color.Gray;

        }

        private void AdminLabel_MouseLeave(object sender, EventArgs e)
        {
            AdminLabel.ForeColor = Color.White;
        }

        private void Mainlabel_Click(object sender, EventArgs e)
        {
            OpenInWindow(new MainWindowForm(this));
        }

        private void CashierLabel_Click(object sender, EventArgs e)
        {
            OpenInWindow(new CashierMainWindow());
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            OpenInWindow(new AdminPanelWindowForm());
        }
    }
}
