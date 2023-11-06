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
        MainWindow mainWindow;
        public MainWindowForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow; 
        }

        private void GotoRouteButton_Click(object sender, EventArgs e)
        {
            var route = new RouteWindow();
            mainWindow.OpenInwindow(route);
        }
    }
}
