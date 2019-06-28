using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitingList.Data;
using WaitingList.Properties;

namespace WaitingList
{
    public partial class CustomerForm : Form
    {
        public CustomerForm(Customer customer)
        {
            InitializeComponent();

            _customer = customer;
            Icon = Resources.Cat_Icon;
        }

        private Customer _customer;

        private void ReadFromEntity()
        {
            txbFirstName.Text = _customer.FirstName;
            txbLastName.Text = _customer.LastName;
            txbAddress.Text = _customer.Address;
            txbCountry.Text = _customer.Country;
            txbEmail.Text = _customer.Email;
        }

        private void WriteToEntity()
        {
            _customer.FirstName = txbFirstName.Text;
            _customer.LastName = txbLastName.Text;
            _customer.Address = txbAddress.Text;
            _customer.Country = txbCountry.Text;
            _customer.Email = txbEmail.Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRegist_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            if (_customer.CustomerId == 0)
                DB.Customer.Insert(_customer);
            else
                DB.Customer.Update(_customer);

            Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {   // 열을 더블클릭하면 뜨는 수정폼에 데이터 채워넣기
            bdsCustomer.DataSource = DB.Customer.GetAll();

            ReadFromEntity();
        }
    }
}
