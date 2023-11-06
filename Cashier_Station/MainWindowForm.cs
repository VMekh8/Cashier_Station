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
    public partial class MainWindowForm : Form
    {
        UIClass uI = new UIClass();
        MainWindow MainWindow;
        public MainWindowForm()
        {
            InitializeComponent();
            
        }

        private void GoToTicketButton_Click(object sender, EventArgs e)
        {
            uI.OpenInWindow(new RouteWindow(), MainWindow.GetMainPanel());
        }
    }
}
