
namespace BidiCommDesktop
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMitt = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServ = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.labResult = new System.Windows.Forms.Label();
            this.txtServerURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConn = new System.Windows.Forms.Button();
            this.grpMaster = new System.Windows.Forms.GroupBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.grpMaster.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "mittente";
            // 
            // txtMitt
            // 
            this.txtMitt.Location = new System.Drawing.Point(65, 38);
            this.txtMitt.Name = "txtMitt";
            this.txtMitt.Size = new System.Drawing.Size(143, 20);
            this.txtMitt.TabIndex = 1;
            this.txtMitt.Text = "desktop";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(90, 19);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(100, 20);
            this.txtDest.TabIndex = 2;
            this.txtDest.Text = "server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "destinatario";
            // 
            // txtServ
            // 
            this.txtServ.Location = new System.Drawing.Point(90, 46);
            this.txtServ.Name = "txtServ";
            this.txtServ.Size = new System.Drawing.Size(100, 20);
            this.txtServ.TabIndex = 4;
            this.txtServ.Text = "somma";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(90, 73);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 5;
            this.txtA.Text = "987";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(90, 99);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 6;
            this.txtB.Text = "654";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "nome servizio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "b";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(14, 139);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 26);
            this.btnExec.TabIndex = 10;
            this.btnExec.Text = "Esegui";
            this.btnExec.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(6, 22);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(253, 212);
            this.lstLog.TabIndex = 11;
            // 
            // labResult
            // 
            this.labResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResult.Location = new System.Drawing.Point(96, 144);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(67, 17);
            this.labResult.TabIndex = 13;
            this.labResult.Text = "labResult";
            // 
            // txtServerURL
            // 
            this.txtServerURL.Location = new System.Drawing.Point(65, 12);
            this.txtServerURL.Name = "txtServerURL";
            this.txtServerURL.Size = new System.Drawing.Size(143, 20);
            this.txtServerURL.TabIndex = 14;
            this.txtServerURL.Text = "https://localhost:44304/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "server url";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(146, 64);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(62, 25);
            this.btnConn.TabIndex = 16;
            this.btnConn.Text = "Connetti";
            this.btnConn.UseVisualStyleBackColor = true;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.txtDest);
            this.grpMaster.Controls.Add(this.label2);
            this.grpMaster.Controls.Add(this.txtServ);
            this.grpMaster.Controls.Add(this.labResult);
            this.grpMaster.Controls.Add(this.txtA);
            this.grpMaster.Controls.Add(this.txtB);
            this.grpMaster.Controls.Add(this.label3);
            this.grpMaster.Controls.Add(this.btnExec);
            this.grpMaster.Controls.Add(this.label4);
            this.grpMaster.Controls.Add(this.label5);
            this.grpMaster.Location = new System.Drawing.Point(12, 104);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(196, 177);
            this.grpMaster.TabIndex = 17;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "Master-role";
            // 
            // grpLog
            // 
            this.grpLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLog.Controls.Add(this.lstLog);
            this.grpLog.Location = new System.Drawing.Point(217, 12);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(265, 269);
            this.grpLog.TabIndex = 18;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 293);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.txtMitt);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServerURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMitt;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServ;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.TextBox txtServerURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.GroupBox grpMaster;
        private System.Windows.Forms.GroupBox grpLog;
    }
}

