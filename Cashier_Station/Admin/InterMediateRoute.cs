using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Station.Admin
{
    public partial class InterMediateRouteWindow : Form
    {
        public InterMediateRouteWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
