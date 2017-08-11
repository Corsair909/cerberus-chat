using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using Telerik.WinControls;

namespace Cerberus_Network
{
    public partial class Entrance : Telerik.WinControls.UI.RadForm
    {
        public Entrance()
        {
            InitializeComponent();
            tx_bx_login.Focus();
        }
        #region Вход и Выход
        private void Entrance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Want to quit?", "Chat Clousing", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=10.10.10.34;Initial Catalog=01n;Persist Security Info=True;User ID=hat_un;Password=AboveReproach1;");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM Enrance Where Login = '" + tx_bx_login.Text.Trim() + "'and Password = '" + tx_bx_pass.Text.Trim() + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    LoginMethod();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    tx_bx_login.Clear();
                    tx_bx_pass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void LoginMethod()
        {
            Chat chat = new Chat();
            Chat.name = tx_bx_login.Text;
            MainForm MF = new MainForm();

            this.Hide();
            MF.ShowDialog();
            Close();
        }

        private void tx_bx_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginMethod();
            }
        }
        private void Entrance_Load(object sender, EventArgs e)
        {
            tx_bx_login.Focus();
        }
    }
}
