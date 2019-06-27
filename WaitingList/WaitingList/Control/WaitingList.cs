using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WaitingList.Control
{
    public partial class WaitingList : XtraUserControl
    {
        public WaitingList()
        {
            InitializeComponent();
        }

        private void BtnWaiterDel_Click(object sender, EventArgs e)
        {
            if (lbwaitingList.SelectedIndex > -1)
                lbwaitingList.Items.RemoveAt(lbwaitingList.SelectedIndex);
        }

        private void BtnWaiterAlarm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{lbwaitingList.TabIndex}님 오셈");
        }

        internal class Customer
        {
        }

        internal class Control
        {
            internal class WaitingList
            {
                internal class Customer
                {
                }
            }
        }
    }
}
