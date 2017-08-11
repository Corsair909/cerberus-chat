using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace Cerberus_Network
{
    public partial class NewBroker : Telerik.WinControls.UI.RadForm
    {
        DAL dal = new DAL();
        public NewBroker()
        {
            InitializeComponent();
        }

        private void btn_saveNewBroker_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewBroker(txbx_brokerID.Text.Trim(),
                txbx_name.Text.Trim(),
                txbx_act.Text.Trim(),
                txbx_address.Text.Trim(),
                txbx_phone.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;//закрытие формы по нажатию клавиши "save new broker"
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void NewBroker_Load(object sender, EventArgs e)
        {

        }
    }
}
