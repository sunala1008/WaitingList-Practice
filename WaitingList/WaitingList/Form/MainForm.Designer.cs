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
            this.tpPatient = new System.Windows.Forms.TabPage();
            this.uscPatientControl = new WaitingList.Control.Patient();
            this.tpTreat = new System.Windows.Forms.TabPage();
            this.uscTreatment = new WaitingList.Control.Treatment();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbMainwaitingList = new System.Windows.Forms.ListBox();
            this.btnWaiterCalling = new System.Windows.Forms.Button();
            this.btnWaiterDel = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpPatient.SuspendLayout();
            this.tpTreat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpPatient);
            this.tcMain.Controls.Add(this.tpTreat);
            this.tcMain.Location = new System.Drawing.Point(154, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(674, 426);
            this.tcMain.TabIndex = 0;
            // 
            // tpPatient
            // 
            this.tpPatient.Controls.Add(this.uscPatientControl);
            this.tpPatient.Location = new System.Drawing.Point(4, 22);
            this.tpPatient.Name = "tpPatient";
            this.tpPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpPatient.Size = new System.Drawing.Size(666, 400);
            this.tpPatient.TabIndex = 1;
            this.tpPatient.Text = "환자";
            this.tpPatient.UseVisualStyleBackColor = true;
            // 
            // uscPatientControl
            // 
            this.uscPatientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscPatientControl.Location = new System.Drawing.Point(3, 3);
            this.uscPatientControl.Name = "uscPatientControl";
            this.uscPatientControl.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uscPatientControl.Size = new System.Drawing.Size(660, 394);
            this.uscPatientControl.TabIndex = 0;
            this.uscPatientControl.SearchButtonClicked += new System.EventHandler<WaitingList.Control.Patient.SearchButtonClickedEventArgs>(this.UscPatientControl_SearchButtonClicked);
            this.uscPatientControl.RegistButtonClicked += new System.EventHandler<WaitingList.Control.Patient.RegistButtonClickedEventArgs>(this.UscPatientControl_RegistButtonClicked);
            this.uscPatientControl.CustomerRowDoubleClicked += new System.EventHandler<WaitingList.Control.Patient.CustomerRowDoubleClickedEventArgs>(this.UscPatientControl_CustomerRowDoubleClicked);
            // 
            // tpTreat
            // 
            this.tpTreat.Controls.Add(this.uscTreatment);
            this.tpTreat.Location = new System.Drawing.Point(4, 22);
            this.tpTreat.Name = "tpTreat";
            this.tpTreat.Size = new System.Drawing.Size(666, 400);
            this.tpTreat.TabIndex = 2;
            this.tpTreat.Text = "진료";
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
            this.button1.Text = "환자";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "진료";
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
            // lbMainwaitingList
            // 
            this.lbMainwaitingList.AllowDrop = true;
            this.lbMainwaitingList.FormattingEnabled = true;
            this.lbMainwaitingList.ItemHeight = 12;
            this.lbMainwaitingList.Location = new System.Drawing.Point(12, 140);
            this.lbMainwaitingList.Name = "lbMainwaitingList";
            this.lbMainwaitingList.Size = new System.Drawing.Size(136, 184);
            this.lbMainwaitingList.TabIndex = 1;
            // 
            // btnWaiterCalling
            // 
            this.btnWaiterCalling.Location = new System.Drawing.Point(12, 336);
            this.btnWaiterCalling.Name = "btnWaiterCalling";
            this.btnWaiterCalling.Size = new System.Drawing.Size(50, 46);
            this.btnWaiterCalling.TabIndex = 4;
            this.btnWaiterCalling.Text = "호출";
            this.btnWaiterCalling.UseVisualStyleBackColor = true;
            this.btnWaiterCalling.Click += new System.EventHandler(this.BtnWaiterAlarm_Click);
            // 
            // btnWaiterDel
            // 
            this.btnWaiterDel.Location = new System.Drawing.Point(98, 336);
            this.btnWaiterDel.Name = "btnWaiterDel";
            this.btnWaiterDel.Size = new System.Drawing.Size(50, 46);
            this.btnWaiterDel.TabIndex = 5;
            this.btnWaiterDel.Text = "삭제";
            this.btnWaiterDel.UseVisualStyleBackColor = true;
            this.btnWaiterDel.Click += new System.EventHandler(this.BtnWaiterDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnWaiterDel);
            this.Controls.Add(this.btnWaiterCalling);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMainwaitingList);
            this.Controls.Add(this.tcMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tcMain.ResumeLayout(false);
            this.tpPatient.ResumeLayout(false);
            this.tpTreat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpTreat;
        private System.Windows.Forms.TabPage tpPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuit;
        private Control.Patient uscPatientControl;
        private System.Windows.Forms.ListBox lbMainwaitingList;
        private System.Windows.Forms.Button btnWaiterCalling;
        private System.Windows.Forms.Button btnWaiterDel;
        private Control.Treatment uscTreatmentControl;
        private Control.Treatment uscTreatment;
    }
}

