using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using WaitingList.Data;
using System.Drawing;
using WaitingList.Properties;

namespace WaitingList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Icon = Resources.Cat_Icon;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpCustomer;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tcMain.SelectedTab = tpInfo;
        }

        private void UscPatientControl_SearchButtonClicked(object sender, Control.Patient.SearchButtonClickedEventArgs e)
        {
            var customer = DB.Customer.Search(e.Name);
            uscPatientControl.SetDataSource(customer);
        }

        private void BtnWaiterDel_Click(object sender, EventArgs e)
        {
            if (lbMainList.SelectedIndex > -1)
                lbMainList.Items.RemoveAt(lbMainList.SelectedIndex);
        }

        private void BtnWaiterAlarm_Click(object sender, EventArgs e)
        {
            lbMainList.SelectedIndex = 0;
            MessageBox.Show($"{lbMainList.Text}의 세부 정보탭으로 넘어갑니다.");

            tcMain.SelectedTab = tpInfo;

            lbMainList.Items.RemoveAt(lbMainList.SelectedIndex);
        }

        private void UscPatientControl_RegistButtonClicked(object sender, Control.Patient.RegistButtonClickedEventArgs e)
        {
            if (!lbMainList.Items.Contains(e.Name))
                lbMainList.Items.Add(e.Name); // 같은 열 중복해서 대기열 등록 불가
        }

        private void UscPatientControl_CustomerRowDoubleClicked(object sender, Control.Patient.CustomerRowDoubleClickedEventArgs e)
        {
            Customer customer = e.Customer;

            if (customer == null)
                return;

            //CustomerForm form = new CustomerForm(customer);
            //form.Show();
            tcMain.SelectedTab = tpInfo;
        }
    }
}
