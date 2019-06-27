﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaitingList.Data;

namespace WaitingList.Control
{
    public partial class Patient : UserControl
    {
        public Patient()
        {
            InitializeComponent();

            //bdsCustomer.DataSource = DB.Customer.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string Name = txbName.Text;

            OnSearchButtonClicked(Name);
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string name)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(name);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion

        public void SetDataSource(List<Customer> list)
        {
            bdsCustomer.DataSource = list;
        }
        
        #region RegistButtonClicked event things for C# 3.0
        public event EventHandler<RegistButtonClickedEventArgs> RegistButtonClicked;

        protected virtual void OnRegistButtonClicked(RegistButtonClickedEventArgs e)
        {
            if (RegistButtonClicked != null)
                RegistButtonClicked(this, e);
        }

        private RegistButtonClickedEventArgs OnRegistButtonClicked(string name)
        {
            RegistButtonClickedEventArgs args = new RegistButtonClickedEventArgs(name);
            OnRegistButtonClicked(args);

            return args;
        }

        private RegistButtonClickedEventArgs OnRegistButtonClickedForOut()
        {
            RegistButtonClickedEventArgs args = new RegistButtonClickedEventArgs();
            OnRegistButtonClicked(args);

            return args;
        }

        public class RegistButtonClickedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public RegistButtonClickedEventArgs()
            {
            }

            public RegistButtonClickedEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion

        private void BtnRegist_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
                MessageBox.Show("환자를 선택해 주세요.");
            else
            {
                int rowIndex = dgvList.CurrentRow.Index;

                string name = dgvList.Rows[rowIndex].Cells[0].Value.ToString() + " "  + dgvList.Rows[rowIndex].Cells[1].Value.ToString();

                OnRegistButtonClicked(name);
            }
        }

        private void DgvList_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Insert)
            {
                Customer customer = new Customer();

                CustomerForm form = new CustomerForm(customer);
                form.ShowDialog();
            }
            else if(e.KeyCode == Keys.Delete)
            {
                Customer customer = dgvList.CurrentRow.DataBoundItem as Customer;

                if (customer == null)
                    return;

                if (FormHelper.SureToDelete())
                    DB.Customer.Delete(customer);
                    
            }
        }

        private void BtnNewRegist_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            CustomerForm form = new CustomerForm(customer);
            form.ShowDialog();
        }

        private void DgvList_DoubleClick(object sender, EventArgs e)
        {
            Customer customer = dgvList.CurrentRow.DataBoundItem as Customer;

            if (customer == null)
                return;

            OnCustomerRowDoubleClicked(customer);
        }

        #region CustomerRowDoubleClicked event things for C# 3.0
        public event EventHandler<CustomerRowDoubleClickedEventArgs> CustomerRowDoubleClicked;

        protected virtual void OnCustomerRowDoubleClicked(CustomerRowDoubleClickedEventArgs e)
        {
            if (CustomerRowDoubleClicked != null)
                CustomerRowDoubleClicked(this, e);
        }

        private CustomerRowDoubleClickedEventArgs OnCustomerRowDoubleClicked(Customer customer)
        {
            CustomerRowDoubleClickedEventArgs args = new CustomerRowDoubleClickedEventArgs(customer);
            OnCustomerRowDoubleClicked(args);

            return args;
        }

        private CustomerRowDoubleClickedEventArgs OnCustomerRowDoubleClickedForOut()
        {
            CustomerRowDoubleClickedEventArgs args = new CustomerRowDoubleClickedEventArgs();
            OnCustomerRowDoubleClicked(args);

            return args;
        }

        public class CustomerRowDoubleClickedEventArgs : EventArgs
        {
            public Customer Customer { get; set; }

            public CustomerRowDoubleClickedEventArgs()
            {
            }

            public CustomerRowDoubleClickedEventArgs(Customer customer)
            {
                Customer = customer;
            }
        }
        #endregion
    }
}
