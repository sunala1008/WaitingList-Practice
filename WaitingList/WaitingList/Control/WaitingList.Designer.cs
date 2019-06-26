namespace WaitingList.Control
{
    partial class WaitingList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWaiterDel = new System.Windows.Forms.Button();
            this.btnWaiterAlarm = new System.Windows.Forms.Button();
            this.lbwaitingList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnWaiterDel
            // 
            this.btnWaiterDel.Location = new System.Drawing.Point(89, 199);
            this.btnWaiterDel.Name = "btnWaiterDel";
            this.btnWaiterDel.Size = new System.Drawing.Size(50, 46);
            this.btnWaiterDel.TabIndex = 8;
            this.btnWaiterDel.Text = "삭제";
            this.btnWaiterDel.UseVisualStyleBackColor = true;
            this.btnWaiterDel.Click += new System.EventHandler(this.BtnWaiterDel_Click);
            // 
            // btnWaiterAlarm
            // 
            this.btnWaiterAlarm.Location = new System.Drawing.Point(3, 199);
            this.btnWaiterAlarm.Name = "btnWaiterAlarm";
            this.btnWaiterAlarm.Size = new System.Drawing.Size(50, 46);
            this.btnWaiterAlarm.TabIndex = 7;
            this.btnWaiterAlarm.Text = "호출";
            this.btnWaiterAlarm.UseVisualStyleBackColor = true;
            this.btnWaiterAlarm.Click += new System.EventHandler(this.BtnWaiterAlarm_Click);
            // 
            // lbwaitingList
            // 
            this.lbwaitingList.FormattingEnabled = true;
            this.lbwaitingList.ItemHeight = 12;
            this.lbwaitingList.Location = new System.Drawing.Point(3, 3);
            this.lbwaitingList.Name = "lbwaitingList";
            this.lbwaitingList.Size = new System.Drawing.Size(136, 184);
            this.lbwaitingList.TabIndex = 6;
            // 
            // WaitingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWaiterDel);
            this.Controls.Add(this.btnWaiterAlarm);
            this.Controls.Add(this.lbwaitingList);
            this.Name = "WaitingList";
            this.Size = new System.Drawing.Size(143, 248);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWaiterDel;
        private System.Windows.Forms.Button btnWaiterAlarm;
        private System.Windows.Forms.ListBox lbwaitingList;
    }
}
