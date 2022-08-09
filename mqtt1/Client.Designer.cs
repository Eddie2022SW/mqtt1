namespace mqtt1
{
    partial class Frm_Client
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
            this.components = new System.ComponentModel.Container();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientIp = new System.Windows.Forms.TextBox();
            this.btnGoServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.publishTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(519, 162);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(106, 48);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(519, 87);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 48);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(239, 174);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(175, 28);
            this.txtClientPort.TabIndex = 7;
            this.txtClientPort.Text = "1883";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ClientPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ClientIP";
            // 
            // txtClientIp
            // 
            this.txtClientIp.Location = new System.Drawing.Point(239, 99);
            this.txtClientIp.Name = "txtClientIp";
            this.txtClientIp.Size = new System.Drawing.Size(175, 28);
            this.txtClientIp.TabIndex = 10;
            this.txtClientIp.Text = "172.20.86.110";
            // 
            // btnGoServer
            // 
            this.btnGoServer.Location = new System.Drawing.Point(671, 257);
            this.btnGoServer.Name = "btnGoServer";
            this.btnGoServer.Size = new System.Drawing.Size(98, 54);
            this.btnGoServer.TabIndex = 11;
            this.btnGoServer.Text = "Server";
            this.btnGoServer.UseVisualStyleBackColor = true;
            this.btnGoServer.Click += new System.EventHandler(this.btnGoServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pwd:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(239, 231);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 28);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "sa";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(239, 275);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(175, 28);
            this.txtPwd.TabIndex = 13;
            this.txtPwd.Text = "sa123";
            // 
            // publishTimer
            // 
            this.publishTimer.Interval = 1000;
            this.publishTimer.Tick += new System.EventHandler(this.publishTimer_Tick);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(519, 260);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(106, 48);
            this.btnPublish.TabIndex = 14;
            this.btnPublish.Text = "手动单次发布";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // Frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGoServer);
            this.Controls.Add(this.txtClientIp);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientIp;
        private System.Windows.Forms.Button btnGoServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnPublish;
        public System.Windows.Forms.Timer publishTimer;
    }
}