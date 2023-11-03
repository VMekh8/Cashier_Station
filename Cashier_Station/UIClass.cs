using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Station
{
    public class UIClass
    {
        public void OpenInWindow(Form fm, Panel p)
        {
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Clear();
            p.Controls.Add(fm);
            fm.Visible = true;
        }
    }
}
