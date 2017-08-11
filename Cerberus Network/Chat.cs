using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace Cerberus_Network
{
    public partial class Chat : Telerik.WinControls.UI.RadForm
    {
        bool alive = false;
        UdpClient client;
        int localport = 8004;
        int remoteport = 8003;
        int ttl = 20;
        string host = "235.5.5.1";
        IPAddress groupAddress;
        internal static string name;

        public int LOCALPORT
        {
            get { return localport; }
            set { this.localport = value; }
        }
        public int REMOTEPORT
        {
            get { return remoteport; }
            set { this.remoteport = value; }
        }
        public int TTL
        {
            get { return ttl; }
            set { this.ttl = value; }
        }
        public string HOST
        {
            get { return host; }
            set { this.host = value; }
        }

        public Chat()
        {
            InitializeComponent();
            groupAddress = IPAddress.Parse(host);
        }

        #region
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
            {
                if (MessageBox.Show("Do you really want to leave the chat ?", "Chat Clousing", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void ExitChat()
        {
            string message = name + " logged out...";

            SendMessage(message);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
        }
        #endregion

        private void Chat_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateTimePicker1.Value = date;
            client = new UdpClient(localport);
            client.JoinMulticastGroup(groupAddress, ttl);
            Task receiveTask = new Task(ReceiveMessageFn);
            receiveTask.Start();
            string message = name + " joined the room...";
            if (message.Contains(name + " joined the room..."))

                history_messageTableAdapter1.InsertQuery(name, " joined the room...", dateTimePicker1.Value);


            history_messageTableAdapter1.InsertQuery(name, txtTextMessage.Text, dateTimePicker1.Value);
            SendMessage(message);
            ShowMessage(message);

            txtTextMessage.Focus();
        }

        public void ReceiveMessageFn()
        {
            alive = true;

            while (true)
            {
                try
                {
                    IPEndPoint remoteIp = null;
                    byte[] receve = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(receve);
                    ShowMessage(message);
                }

                catch { }
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                DateTime date = DateTime.Now;
                dateTimePicker1.Value = date;
                Byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, host, remoteport);
                history_messageTableAdapter1.InsertQuery(name, txtTextMessage.Text, dateTimePicker1.Value);
                txtTextMessage.Clear();
                txtTextMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTextMessage.Text))
            {
                string message = name + " says >> " + txtTextMessage.Text;

                SendMessage(message);
                ShowMessage(message);
            }
            txtTextMessage.Clear();
            txtTextMessage.Focus();
        }

        private void txtMessageWindow_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtTextMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtTextMessage.Text))
                {
                    string data = name + " says >> " + txtTextMessage.Text;
                    SendMessage(data);
                    ShowMessage(data);
                }
            }
        }

        private void ShowMessage(string message)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate () { ShowMessage(message); }));
            else
            {
                if (message.Contains(name + " says >>"))
                {
                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + message.Replace(name + " says >>", "Me says >>");
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    richTextBox1.ScrollToCaret();
                    richTextBox1.Refresh();
                }

                else
                {
                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + message;
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    richTextBox1.ScrollToCaret();
                    richTextBox1.Refresh();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History historychat = new History();
            historychat.Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void goToSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings(localport, remoteport, ttl, host);
            set.Owner = this;
            set.ShowDialog();
        }

        private void goToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chat.ActiveForm.Hide();
            MainForm MF = new MainForm();
            MF.ShowDialog();
            Close();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Chat.ActiveForm.Hide();
            Entrance EntrForm = new Entrance();
            EntrForm.ShowDialog();
            Close();
        }
    }
}