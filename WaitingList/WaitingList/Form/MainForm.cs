using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using WaitingList.Data;

namespace WaitingList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tpPatient;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tc.SelectedTab = tpTreat;
        }

        private void UscPatientControl_SearchButtonClicked(object sender, Control.Patient.SearchButtonClickedEventArgs e)
        {
            var customer = DB.Customer.Search(e.Name);
            uscPatientControl.SetDataSource(customer);
        }

        private void BtnWaiterDel_Click(object sender, EventArgs e)
        {
            if (lbMainwaitingList.SelectedIndex > -1)
                lbMainwaitingList.Items.RemoveAt(lbMainwaitingList.SelectedIndex);
        }

        private void BtnWaiterAlarm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{lbMainwaitingList.Text}님 들어오세요.");

            tc.SelectedTab = tpTreat;
        }

        private void UscPatientControl_RegistButtonClicked(object sender, Control.Patient.RegistButtonClickedEventArgs e)
        {
            if (!lbMainwaitingList.Items.Contains(e.Name))
                lbMainwaitingList.Items.Add(e.Name); // 같은 열 중복해서 대기열 등록 불가
        }

        private void UscPatientControl_CustomerRowDoubleClicked(object sender, Control.Patient.CustomerRowDoubleClickedEventArgs e)
        {
            Customer customer = e.Customer;

            if (customer == null)
                return;

            CustomerForm form = new CustomerForm(customer);
            form.Show();
        }
    }
}
