using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cerberus_Network
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void btnToLog_Click(object sender, EventArgs e)
        {
            RadForm1.ActiveForm.Hide();
            Entrance EntrForm = new Entrance();
            EntrForm.ShowDialog();
            Close();
        }
    }
}
