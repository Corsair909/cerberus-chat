namespace Cerberus_Network
{
    partial class Entrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance));
            this.tx_bx_login = new Telerik.WinControls.UI.RadTextBox();
            this.tx_bx_pass = new Telerik.WinControls.UI.RadTextBox();
            this.btnLog = new Telerik.WinControls.UI.RadButton();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bx_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bx_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_bx_login
            // 
            this.tx_bx_login.Location = new System.Drawing.Point(481, 271);
            this.tx_bx_login.Name = "tx_bx_login";
            this.tx_bx_login.Size = new System.Drawing.Size(194, 20);
            this.tx_bx_login.TabIndex = 0;
            // 
            // tx_bx_pass
            // 
            this.tx_bx_pass.Location = new System.Drawing.Point(481, 298);
            this.tx_bx_pass.Name = "tx_bx_pass";
            this.tx_bx_pass.Size = new System.Drawing.Size(194, 20);
            this.tx_bx_pass.TabIndex = 1;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(567, 330);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(110, 29);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log Out";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(741, 399);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.tx_bx_pass);
            this.Controls.Add(this.tx_bx_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrance";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Entrance";
            this.ThemeName = "Desert";
            ((System.ComponentModel.ISupportInitialize)(this.tx_bx_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bx_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox tx_bx_login;
        private Telerik.WinControls.UI.RadTextBox tx_bx_pass;
        private Telerik.WinControls.UI.RadButton btnLog;
        private Telerik.WinControls.UI.RadButton btnExit;
    }
}
