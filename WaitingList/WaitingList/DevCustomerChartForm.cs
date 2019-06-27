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

namespace WaitingList
{
    public partial class DevCustomerChartForm : Form
    {
        public DevCustomerChartForm()
        {
            InitializeComponent();
        }

        private void DevCustomerChartForm_Load(object sender, EventArgs e)
        {
            bdsCustomer.DataSource = DB.Customer.GetAll();
        }
    }
}
