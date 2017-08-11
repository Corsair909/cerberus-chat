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
    public partial class Settings : Telerik.WinControls.UI.RadForm
    {
        int localport;
        int remoteport;
        int ttl;
        string host;

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

        public Settings(int localport, int remoteport, int ttl, string host)
        {
            InitializeComponent();
            this.localport = localport;
            this.remoteport = remoteport;
            this.ttl = ttl;
            this.host = host;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tx_bx_local_port.Text = localport.ToString();
            tx_bx_remoter_port.Text = remoteport.ToString();
            tx_bx_limit_steps.Text = ttl.ToString();
            tx_bx_IP_host.Text = host;
        }

        private void btn_OK_settings_Click(object sender, EventArgs e)
        {
            Chat chat = (Chat)this.Owner;
            localport = Int32.Parse(tx_bx_local_port.Text);
            chat.LOCALPORT = localport;
            remoteport = Int32.Parse(tx_bx_remoter_port.Text);
            chat.REMOTEPORT = remoteport;

            ttl = Int32.Parse(tx_bx_limit_steps.Text);
            chat.TTL = ttl;
            tx_bx_IP_host.Text = chat.HOST;
            this.Close();
            chat.Show();
        }
    }
}
