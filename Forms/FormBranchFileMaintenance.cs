using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T21_Library.Repositories;

namespace T21.Forms
{
    public partial class FormBranchFileMaintenance : Form
    {
        private readonly BranchRepository _branchRepository;
        private readonly CompanyRepository _companyRepository;

        public FormBranchFileMaintenance(BranchRepository branchRepository, CompanyRepository companyRepository)
        {
            InitializeComponent();
            _branchRepository = branchRepository;
            _companyRepository = companyRepository;
        }

        private void FormBranchFileMaintenance_Load(object sender, EventArgs e)
        {
            labelCustomerName.Text = "";
            labelSupplierName.Text = "";

            // Populates the comboboxes with the company names and indexes
            comboBoxSelectCompany.DataSource = _companyRepository.GetAllCompanies();
            comboBoxSelectCompany.DisplayMember = "CompanyName";
            comboBoxSelectCompany.ValueMember = "CompanyCode";
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // Clears all textboxes and comboboxes and sets the focus to the first textbox
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                if (c is Label)
                {
                    ((Label)c).Text = "";
                }
            }

            textBoxBranchName.Focus();
        }

        private void toolStripButtonSubmit_Click(object sender, EventArgs e)
        {
            var companies = _companyRepository.GetCompanyByCompanyCode(Convert.ToInt32(comboBoxSelectCompany.SelectedValue));

            if (_branchRepository.GetBranchByBranchName(textBoxBranchName.Text) != null)
            {
                var branch = _branchRepository.GetBranchByBranchName(textBoxBranchName.Text);
                branch.BranchName = textBoxBranchName.Text;
                branch.Address1 = textBoxAddress1.Text;
                branch.Address2 = textBoxAddress2.Text;
                branch.Address3 = textBoxAddress3.Text;
                branch.Address4 = textBoxAddress4.Text;
                branch.Address5 = textBoxAddress5.Text;
                branch.PostCode = textBoxPostCode.Text;
                branch.Telephone = textBoxTelephoneNumber.Text;
                branch.Fax = textBoxFaxNumber.Text;
                branch.VisibleCompanies = companies.CompanyCode;
                branch.GlobalInvoiceMessage = textBoxInvoiceMessage.Text;
                branch.CustomerLookup = Convert.ToInt32(textBoxCustomerLookup.Text); // TODO: Add a lookup for customer
                branch.SupplierLookup = Convert.ToInt32(textBoxSupplierLookup.Text); // TODO: Add a lookup for supplier
                branch.CurrencyLookup = Convert.ToInt32(textBoxCurrencyLookup.Text); // TODO: Add a lookup for currency

                _branchRepository.UpdateBranch(branch);

                MessageBox.Show("Branch Updated", "Branch File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripButtonCancel_Click(sender, e);
            }
            else
            {
                var branch = new T21_Library.Models.Branch
                {
                    BranchName = textBoxBranchName.Text,
                    Address1 = textBoxAddress1.Text,
                    Address2 = textBoxAddress2.Text,
                    Address3 = textBoxAddress3.Text,
                    Address4 = textBoxAddress4.Text,
                    Address5 = textBoxAddress5.Text,
                    PostCode = textBoxPostCode.Text,
                    Telephone = textBoxTelephoneNumber.Text,
                    Fax = textBoxFaxNumber.Text,
                    VisibleCompanies = companies.CompanyCode,
                    GlobalInvoiceMessage = textBoxInvoiceMessage.Text,
                    CustomerLookup = Convert.ToInt32(textBoxCustomerLookup.Text), // TODO: Add a lookup for customer
                    SupplierLookup = Convert.ToInt32(textBoxSupplierLookup.Text), // TODO: Add a lookup for supplier
                    CurrencyLookup = Convert.ToInt32(textBoxCurrencyLookup.Text), // TODO: Add a lookup for currency
                };

                _branchRepository.AddBranch(branch);
             
                MessageBox.Show("Branch Added", "Branch File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripButtonCancel_Click(sender, e);
            }
        }
    }
}
