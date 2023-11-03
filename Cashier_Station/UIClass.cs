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
            Form frm = new Form();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            p.Controls.Clear();
            p.Controls.Add(frm);
            frm.Visible = true;
        }
    }
}
