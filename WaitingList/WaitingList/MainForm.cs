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

            OnCallingButtonClicked(lbMainwaitingList.Text);
            
        }

        #region CallingButtonClicked event things for C# 3.0
        public event EventHandler<CallingButtonClickedEventArgs> CallingButtonClicked;

        protected virtual void OnCallingButtonClicked(CallingButtonClickedEventArgs e)
        {
            if (CallingButtonClicked != null)
                CallingButtonClicked(this, e);
        }

        private CallingButtonClickedEventArgs OnCallingButtonClicked(string name)
        {
            CallingButtonClickedEventArgs args = new CallingButtonClickedEventArgs(name);
            OnCallingButtonClicked(args);

            return args;
        }

        private CallingButtonClickedEventArgs OnCallingButtonClickedForOut()
        {
            CallingButtonClickedEventArgs args = new CallingButtonClickedEventArgs();
            OnCallingButtonClicked(args);

            return args;
        }

        public class CallingButtonClickedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public CallingButtonClickedEventArgs()
            {
            }

            public CallingButtonClickedEventArgs(string name)
            {
                Name = name;
            }
        }

        #endregion

        private void UscPatientControl_RegistButtonClicked(object sender, Control.Patient.RegistButtonClickedEventArgs e)
        {
            if (!lbMainwaitingList.Items.Contains(e.Name))
            {
                lbMainwaitingList.Items.Add(e.Name); // 같은 열 중복해서 대기열 등록 불가
            }
                
        }



        public string lbMainwaitingList1
        {
            get
            {
                return lbMainwaitingList.Text;
            }
        }
    }
}
