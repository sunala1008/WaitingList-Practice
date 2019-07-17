namespace WaitingList
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.uscPatientControl = new WaitingList.Control.Patient();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.uscTreatment = new WaitingList.Control.Treatment();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbMainList = new System.Windows.Forms.ListBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpCustomer);
            this.tcMain.Controls.Add(this.tpInfo);
            this.tcMain.Location = new System.Drawing.Point(154, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(674, 426);
            this.tcMain.TabIndex = 0;
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.uscPatientControl);
            this.tpCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(666, 400);
            this.tpCustomer.TabIndex = 1;
            this.tpCustomer.Text = "고객";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // uscPatientControl
            // 
            this.uscPatientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscPatientControl.Location = new System.Drawing.Point(3, 3);
            this.uscPatientControl.Name = "uscPatientControl";
            this.uscPatientControl.Padding = new System.Windows.Forms.Padding(5);
            this.uscPatientControl.Size = new System.Drawing.Size(660, 394);
            this.uscPatientControl.TabIndex = 0;
            this.uscPatientControl.SearchButtonClicked += new System.EventHandler<WaitingList.Control.Patient.SearchButtonClickedEventArgs>(this.UscPatientControl_SearchButtonClicked);
            this.uscPatientControl.RegistButtonClicked += new System.EventHandler<WaitingList.Control.Patient.RegistButtonClickedEventArgs>(this.UscPatientControl_RegistButtonClicked);
            this.uscPatientControl.CustomerRowDoubleClicked += new System.EventHandler<WaitingList.Control.Patient.CustomerRowDoubleClickedEventArgs>(this.UscPatientControl_CustomerRowDoubleClicked);
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.uscTreatment);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Size = new System.Drawing.Size(666, 400);
            this.tpInfo.TabIndex = 2;
            this.tpInfo.Text = "세부 정보";
            // 
            // uscTreatment
            // 
            this.uscTreatment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uscTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscTreatment.Location = new System.Drawing.Point(0, 0);
            this.uscTreatment.Name = "uscTreatment";
            this.uscTreatment.Size = new System.Drawing.Size(666, 400);
            this.uscTreatment.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "고객";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "세부 정보";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 392);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(50, 46);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "종료";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lbMainList
            // 
            this.lbMainList.AllowDrop = true;
            this.lbMainList.FormattingEnabled = true;
            this.lbMainList.ItemHeight = 12;
            this.lbMainList.Location = new System.Drawing.Point(12, 140);
            this.lbMainList.Name = "lbMainList";
            this.lbMainList.Size = new System.Drawing.Size(136, 184);
            this.lbMainList.TabIndex = 1;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(12, 336);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(50, 46);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "정보";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.BtnWaiterAlarm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnWaiterDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMainList);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tcMain.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuit;
        private Control.Patient uscPatientControl;
        private System.Windows.Forms.ListBox lbMainList;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnDelete;
        private Control.Treatment uscTreatmentControl;
        private Control.Treatment uscTreatment;
    }
}

