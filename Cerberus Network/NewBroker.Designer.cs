namespace Cerberus_Network
{
    partial class NewBroker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBroker));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_saveNewBroker = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BrokerID = new Telerik.WinControls.UI.RadLabel();
            this.txbx_brokerID = new Telerik.WinControls.UI.RadTextBox();
            this.txbx_name = new Telerik.WinControls.UI.RadTextBox();
            this.txbx_act = new Telerik.WinControls.UI.RadTextBox();
            this.txbx_address = new Telerik.WinControls.UI.RadTextBox();
            this.txbx_phone = new Telerik.WinControls.UI.RadTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_saveNewBroker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_brokerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btn_saveNewBroker);
            this.groupBox1.Controls.Add(this.radLabel5);
            this.groupBox1.Controls.Add(this.radLabel4);
            this.groupBox1.Controls.Add(this.radLabel3);
            this.groupBox1.Controls.Add(this.radLabel2);
            this.groupBox1.Controls.Add(this.BrokerID);
            this.groupBox1.Controls.Add(this.txbx_phone);
            this.groupBox1.Controls.Add(this.txbx_address);
            this.groupBox1.Controls.Add(this.txbx_act);
            this.groupBox1.Controls.Add(this.txbx_name);
            this.groupBox1.Controls.Add(this.txbx_brokerID);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Broker Details";
            // 
            // btn_saveNewBroker
            // 
            this.btn_saveNewBroker.ForeColor = System.Drawing.Color.Red;
            this.btn_saveNewBroker.Location = new System.Drawing.Point(492, 199);
            this.btn_saveNewBroker.Name = "btn_saveNewBroker";
            this.btn_saveNewBroker.Size = new System.Drawing.Size(110, 24);
            this.btn_saveNewBroker.TabIndex = 10;
            this.btn_saveNewBroker.Text = "Save";
            this.btn_saveNewBroker.ThemeName = "Desert";
            this.btn_saveNewBroker.Click += new System.EventHandler(this.btn_saveNewBroker_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.ForeColor = System.Drawing.Color.White;
            this.radLabel5.Location = new System.Drawing.Point(120, 159);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(82, 18);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Phone Number";
            // 
            // radLabel4
            // 
            this.radLabel4.ForeColor = System.Drawing.Color.White;
            this.radLabel4.Location = new System.Drawing.Point(120, 132);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(46, 18);
            this.radLabel4.TabIndex = 8;
            this.radLabel4.Text = "Address";
            // 
            // radLabel3
            // 
            this.radLabel3.ForeColor = System.Drawing.Color.White;
            this.radLabel3.Location = new System.Drawing.Point(120, 105);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 18);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "AuctionID";
            // 
            // radLabel2
            // 
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(120, 78);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(36, 18);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Name";
            // 
            // BrokerID
            // 
            this.BrokerID.ForeColor = System.Drawing.Color.White;
            this.BrokerID.Location = new System.Drawing.Point(120, 50);
            this.BrokerID.Name = "BrokerID";
            this.BrokerID.Size = new System.Drawing.Size(50, 18);
            this.BrokerID.TabIndex = 5;
            this.BrokerID.Text = "BrokerID";
            // 
            // txbx_brokerID
            // 
            this.txbx_brokerID.Location = new System.Drawing.Point(225, 50);
            this.txbx_brokerID.Name = "txbx_brokerID";
            this.txbx_brokerID.Size = new System.Drawing.Size(377, 20);
            this.txbx_brokerID.TabIndex = 0;
            this.txbx_brokerID.ThemeName = "Desert";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(225, 77);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(377, 20);
            this.txbx_name.TabIndex = 1;
            this.txbx_name.ThemeName = "Desert";
            // 
            // txbx_act
            // 
            this.txbx_act.Location = new System.Drawing.Point(225, 104);
            this.txbx_act.Name = "txbx_act";
            this.txbx_act.Size = new System.Drawing.Size(377, 20);
            this.txbx_act.TabIndex = 2;
            this.txbx_act.ThemeName = "Desert";
            // 
            // txbx_address
            // 
            this.txbx_address.Location = new System.Drawing.Point(225, 131);
            this.txbx_address.Name = "txbx_address";
            this.txbx_address.Size = new System.Drawing.Size(377, 20);
            this.txbx_address.TabIndex = 3;
            this.txbx_address.ThemeName = "Desert";
            // 
            // txbx_phone
            // 
            this.txbx_phone.Location = new System.Drawing.Point(225, 158);
            this.txbx_phone.Name = "txbx_phone";
            this.txbx_phone.Size = new System.Drawing.Size(377, 20);
            this.txbx_phone.TabIndex = 4;
            this.txbx_phone.ThemeName = "Desert";
            // 
            // NewBroker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(610, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewBroker";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "NewBroker";
            this.ThemeName = "Desert";
            this.Load += new System.EventHandler(this.NewBroker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_saveNewBroker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrokerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_brokerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbx_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton btn_saveNewBroker;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel BrokerID;
        private Telerik.WinControls.UI.RadTextBox txbx_phone;
        private Telerik.WinControls.UI.RadTextBox txbx_address;
        private Telerik.WinControls.UI.RadTextBox txbx_act;
        private Telerik.WinControls.UI.RadTextBox txbx_name;
        private Telerik.WinControls.UI.RadTextBox txbx_brokerID;
    }
}
