using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Cerberus_Network
{
    public partial class History : Telerik.WinControls.UI.RadForm
    {
        public History()
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_01nDataSet.History_message". При необходимости она может быть перемещена или удалена.
            this.history_messageTableAdapter.Fill(this._01nDataSet.History_message);

        }
    }
}
