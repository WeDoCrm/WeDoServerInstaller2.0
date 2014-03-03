namespace CustomAction
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.LabelLicenseFile = new System.Windows.Forms.Label();
            this.ButtonLicenseFile = new System.Windows.Forms.Button();
            this.LabelCompanyCd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CkBoxKeepConfig = new System.Windows.Forms.CheckBox();
            this.LabelMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonDBReinstall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCrmPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelMsg2 = new System.Windows.Forms.Label();
            this.TextBoxMsgrPort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ButtonMsgrPortCheck = new System.Windows.Forms.Button();
            this.LabelMsgrPortCheckResult = new System.Windows.Forms.Label();
            this.ButtonCrmPortCheck = new System.Windows.Forms.Button();
            this.LabelCrmPortCheckResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.LabelWarning);
            this.groupBox1.Controls.Add(this.LabelLicenseFile);
            this.groupBox1.Controls.Add(this.ButtonLicenseFile);
            this.groupBox1.Controls.Add(this.LabelCompanyCd);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 356);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelWarning.Location = new System.Drawing.Point(27, 102);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(349, 24);
            this.LabelWarning.TabIndex = 10;
            this.LabelWarning.Text = "WeDo Server가 사용하는 DB는 다음과 같은 포트를 사용합니다.\r\n원하는 포트를 직접 지정하실 수 있습니다.";
            // 
            // LabelLicenseFile
            // 
            this.LabelLicenseFile.AutoSize = true;
            this.LabelLicenseFile.Location = new System.Drawing.Point(148, 55);
            this.LabelLicenseFile.Name = "LabelLicenseFile";
            this.LabelLicenseFile.Size = new System.Drawing.Size(0, 12);
            this.LabelLicenseFile.TabIndex = 9;
            // 
            // ButtonLicenseFile
            // 
            this.ButtonLicenseFile.Location = new System.Drawing.Point(23, 49);
            this.ButtonLicenseFile.Name = "ButtonLicenseFile";
            this.ButtonLicenseFile.Size = new System.Drawing.Size(122, 24);
            this.ButtonLicenseFile.TabIndex = 8;
            this.ButtonLicenseFile.Text = "라이센스 파일열기";
            this.ButtonLicenseFile.UseVisualStyleBackColor = true;
            this.ButtonLicenseFile.Click += new System.EventHandler(this.ButtonLicenseFile_Click);
            // 
            // LabelCompanyCd
            // 
            this.LabelCompanyCd.AutoSize = true;
            this.LabelCompanyCd.Location = new System.Drawing.Point(90, 80);
            this.LabelCompanyCd.Name = "LabelCompanyCd";
            this.LabelCompanyCd.Size = new System.Drawing.Size(99, 12);
            this.LabelCompanyCd.TabIndex = 7;
            this.LabelCompanyCd.Text = "회사명(회사코드)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CkBoxKeepConfig);
            this.panel1.Controls.Add(this.LabelMsg);
            this.panel1.Location = new System.Drawing.Point(13, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 54);
            this.panel1.TabIndex = 6;
            // 
            // CkBoxKeepConfig
            // 
            this.CkBoxKeepConfig.AutoSize = true;
            this.CkBoxKeepConfig.Location = new System.Drawing.Point(16, 35);
            this.CkBoxKeepConfig.Name = "CkBoxKeepConfig";
            this.CkBoxKeepConfig.Size = new System.Drawing.Size(96, 16);
            this.CkBoxKeepConfig.TabIndex = 5;
            this.CkBoxKeepConfig.Text = "기존설정유지";
            this.CkBoxKeepConfig.UseVisualStyleBackColor = true;
            // 
            // LabelMsg
            // 
            this.LabelMsg.AutoSize = true;
            this.LabelMsg.Location = new System.Drawing.Point(8, 11);
            this.LabelMsg.Name = "LabelMsg";
            this.LabelMsg.Size = new System.Drawing.Size(251, 12);
            this.LabelMsg.TabIndex = 4;
            this.LabelMsg.Text = "이전에 설치된 서버설정을 유지하시겠습니까?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "회사코드:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "WeDo Server 실행에 필요한 라이센스를 인증합니다. \r\n배포받은 라이센스파일을 찾아 선택하세요.";
            // 
            // ButtonNext
            // 
            this.ButtonNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonNext.Location = new System.Drawing.Point(392, 374);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(87, 23);
            this.ButtonNext.TabIndex = 17;
            this.ButtonNext.Text = "다음 >";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(484, 374);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(87, 23);
            this.ButtonCancel.TabIndex = 16;
            this.ButtonCancel.Text = "취소";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ini";
            this.openFileDialog1.Filter = "WeDo License 파일|*.ini";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // ButtonDBReinstall
            // 
            this.ButtonDBReinstall.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.ButtonDBReinstall.Location = new System.Drawing.Point(299, 374);
            this.ButtonDBReinstall.Name = "ButtonDBReinstall";
            this.ButtonDBReinstall.Size = new System.Drawing.Size(87, 23);
            this.ButtonDBReinstall.TabIndex = 19;
            this.ButtonDBReinstall.Text = "DB재설치 >";
            this.ButtonDBReinstall.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonCrmPortCheck);
            this.panel2.Controls.Add(this.LabelCrmPortCheckResult);
            this.panel2.Controls.Add(this.ButtonMsgrPortCheck);
            this.panel2.Controls.Add(this.LabelMsgrPortCheckResult);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TextBoxCrmPort);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.LabelMsg2);
            this.panel2.Controls.Add(this.TextBoxMsgrPort);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(14, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 130);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(193, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "CRM프로그램이 서버통신에 필요한 포트입니다.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(193, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "메신저간 통신에 필요한 포트입니다.";
            // 
            // TextBoxCrmPort
            // 
            this.TextBoxCrmPort.Location = new System.Drawing.Point(175, 75);
            this.TextBoxCrmPort.MaxLength = 4;
            this.TextBoxCrmPort.Name = "TextBoxCrmPort";
            this.TextBoxCrmPort.Size = new System.Drawing.Size(36, 21);
            this.TextBoxCrmPort.TabIndex = 8;
            this.TextBoxCrmPort.Text = "8886";
            this.TextBoxCrmPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "CRM 포트  ( 기본값 8886 ) :";
            // 
            // LabelMsg2
            // 
            this.LabelMsg2.AutoSize = true;
            this.LabelMsg2.Location = new System.Drawing.Point(5, 12);
            this.LabelMsg2.Name = "LabelMsg2";
            this.LabelMsg2.Size = new System.Drawing.Size(237, 12);
            this.LabelMsg2.TabIndex = 4;
            this.LabelMsg2.Text = "WeDo 서버가 사용하는 포트를 지정합니다.";
            // 
            // TextBoxMsgrPort
            // 
            this.TextBoxMsgrPort.Location = new System.Drawing.Point(175, 29);
            this.TextBoxMsgrPort.MaxLength = 4;
            this.TextBoxMsgrPort.Name = "TextBoxMsgrPort";
            this.TextBoxMsgrPort.Size = new System.Drawing.Size(36, 21);
            this.TextBoxMsgrPort.TabIndex = 5;
            this.TextBoxMsgrPort.Text = "8888";
            this.TextBoxMsgrPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "메신저 포트( 기본값 8888 ) :";
            // 
            // ButtonMsgrPortCheck
            // 
            this.ButtonMsgrPortCheck.Location = new System.Drawing.Point(217, 27);
            this.ButtonMsgrPortCheck.Name = "ButtonMsgrPortCheck";
            this.ButtonMsgrPortCheck.Size = new System.Drawing.Size(89, 23);
            this.ButtonMsgrPortCheck.TabIndex = 16;
            this.ButtonMsgrPortCheck.Text = "사용가능확인";
            this.ButtonMsgrPortCheck.UseVisualStyleBackColor = true;
            this.ButtonMsgrPortCheck.Click += new System.EventHandler(this.ButtonMsgrPortCheck_Click);
            // 
            // LabelMsgrPortCheckResult
            // 
            this.LabelMsgrPortCheckResult.AutoSize = true;
            this.LabelMsgrPortCheckResult.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelMsgrPortCheckResult.Location = new System.Drawing.Point(308, 32);
            this.LabelMsgrPortCheckResult.Name = "LabelMsgrPortCheckResult";
            this.LabelMsgrPortCheckResult.Size = new System.Drawing.Size(185, 12);
            this.LabelMsgrPortCheckResult.TabIndex = 15;
            this.LabelMsgrPortCheckResult.Text = "포트가 사용가능한지 확인하세요.";
            // 
            // ButtonCrmPortCheck
            // 
            this.ButtonCrmPortCheck.Location = new System.Drawing.Point(217, 73);
            this.ButtonCrmPortCheck.Name = "ButtonCrmPortCheck";
            this.ButtonCrmPortCheck.Size = new System.Drawing.Size(89, 23);
            this.ButtonCrmPortCheck.TabIndex = 18;
            this.ButtonCrmPortCheck.Text = "사용가능확인";
            this.ButtonCrmPortCheck.UseVisualStyleBackColor = true;
            this.ButtonCrmPortCheck.Click += new System.EventHandler(this.ButtonCrmPortCheck_Click);
            // 
            // LabelCrmPortCheckResult
            // 
            this.LabelCrmPortCheckResult.AutoSize = true;
            this.LabelCrmPortCheckResult.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelCrmPortCheckResult.Location = new System.Drawing.Point(308, 78);
            this.LabelCrmPortCheckResult.Name = "LabelCrmPortCheckResult";
            this.LabelCrmPortCheckResult.Size = new System.Drawing.Size(185, 12);
            this.LabelCrmPortCheckResult.TabIndex = 17;
            this.LabelCrmPortCheckResult.Text = "포트가 사용가능한지 확인하세요.";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 422);
            this.Controls.Add(this.ButtonDBReinstall);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            this.Text = "WeDo Server 설치 - 라이센스인증";
            this.Shown += new System.EventHandler(this.FrmConfig_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.CheckBox CkBoxKeepConfig;
        private System.Windows.Forms.Label LabelMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonLicenseFile;
        private System.Windows.Forms.Label LabelCompanyCd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelLicenseFile;
        private System.Windows.Forms.Label LabelWarning;
        private System.Windows.Forms.Button ButtonDBReinstall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCrmPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelMsg2;
        private System.Windows.Forms.TextBox TextBoxMsgrPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ButtonCrmPortCheck;
        private System.Windows.Forms.Label LabelCrmPortCheckResult;
        private System.Windows.Forms.Button ButtonMsgrPortCheck;
        private System.Windows.Forms.Label LabelMsgrPortCheckResult;

    }
}