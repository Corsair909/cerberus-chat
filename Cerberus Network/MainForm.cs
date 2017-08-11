using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections;
using Telerik.WinControls;

namespace Cerberus_Network
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        DAL dal = new DAL();
        public MainForm()
        {
            InitializeComponent();
            dal.GetAllBrokers();
            ArrayList allBrokers = dal.GetAllBrokers();
            dgv_brokers.DataSource = allBrokers;

            SettingsDGV_Brokers(); //вызов метода невидимости столбцов
        }
        void SettingsDGV_Brokers() //настройка 'dgv_brokers'
        {
            try
            {
                dgv_brokers.Columns["код_посредника"].Visible = false;    //невидимость столбца таблицы
                dgv_brokers.Columns["код_биржи"].Visible = false;
                dgv_brokers.Columns["адрес"].Visible = false;
                dgv_brokers.Columns["телефон"].Visible = false;

                dgv_brokers.TopLeftHeaderCell.Value = "#";          //левая ячейка заголовка
            }
            catch
            {

            }

        }

        private void dgv_brokers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txbx_name.Text = dgv_brokers.Rows[e.RowIndex].Cells["имя"].Value.ToString();
            txbx_act.Text = dgv_brokers.Rows[e.RowIndex].Cells["код_биржи"].Value.ToString();
            txbx_address.Text = dgv_brokers.Rows[e.RowIndex].Cells["адрес"].Value.ToString();

            string phone = dgv_brokers.Rows[e.RowIndex].Cells["телефон"].Value.ToString();
            txbx_phone.Text = (phone == string.Empty) ? "Нет данных" : phone;


            dgv_datetime.DataSource = dal.GetAllDateTimeForBrokers(dgv_brokers.CurrentRow.Cells["код_посредника"].Value.ToString());
            //подключение времени совершения операций к их владельцам

        }

        private void MainForm_Load(object sender, EventArgs e)      //оптимизация загрузки формы: сначала загружается форма, затем строки из БД
        {
            dgv_brokers.CellEnter += new DataGridViewCellEventHandler(dgv_brokers_CellEnter);
            dgv_datetime.CellEnter += new DataGridViewCellEventHandler(dgv_datetime_CellEnter);
        }
        void dgv_datetime_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string datetimeID = dgv_datetime.CurrentRow.Cells[0].Value.ToString();
            dgv_operation.DataSource = dal.GetAllOperationForDateTime(datetimeID);
            dgv_operation.TopLeftHeaderCell.Value = "#";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Kyrsovaya", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else e.Cancel = true;
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewBrokerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBroker newBroker = new NewBroker();
            if (newBroker.ShowDialog() == DialogResult.OK)       //активным остается только одно окно
                MessageBox.Show("Новый брокер успешно создан!", "Broker", MessageBoxButtons.OK);
            else
                MessageBox.Show("Новый брокер не создан!!", "Broker", MessageBoxButtons.OK);

        }

        List<DataGridViewRow> serchedRows;
        int currentRow;

        private void btn_search_Click(object sender, EventArgs e)
        {
            serchedRows = new List<DataGridViewRow>();
            string namberAuction = txbx_SerchedNamberAuction.Text.Trim();
            string brName = txbx_SerchedBrName.Text.Trim();

            foreach (DataGridViewRow row in dgv_brokers.Rows)
            {
                if (row.Cells["имя"].FormattedValue.ToString().Contains(brName) &&
                    row.Cells["код_биржи"].FormattedValue.ToString().Contains(namberAuction))
                    serchedRows.Add(row);


            }
            if (serchedRows.Count == 0)
            {
                MessageBox.Show("По данному запросу записей не найдено.");
                btn_nextRow.Enabled = false;
                return;
            }

            if (serchedRows.Count % 10 == 0 && serchedRows.Count % 10 > 4 && serchedRows.Count < 10)
            {
                MessageBox.Show("Найдено " + serchedRows.Count + " записей.");
            }
            else
                if (serchedRows.Count % 10 > 2 && serchedRows.Count % 10 < 5)
            {
                MessageBox.Show("Найдено " + serchedRows.Count + " записи.");
            }
            else if (serchedRows.Count % 10 == 1)
            {
                MessageBox.Show("Найдена " + serchedRows.Count + " запись.");
            }
            btn_nextRow.Enabled = true;
            currentRow = -1;
            btn_nextRow_Click(null, null);
        }

        private void btn_nextRow_Click(object sender, EventArgs e)
        {
            if (currentRow == serchedRows.Count - 1)
                currentRow = 0;
            else
                currentRow++;

            dgv_brokers.CurrentCell = serchedRows[currentRow].Cells[0];
        }

        private void enterChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            Chat ch = new Chat();
            ch.ShowDialog();
            Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            Entrance EntrForm = new Entrance();
            EntrForm.ShowDialog();
            Close();
        }
    }
}
