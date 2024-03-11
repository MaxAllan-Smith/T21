using System;
using System.Linq;
using System.Windows.Forms;
using T21_Library.Models;
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
            ClearAllFields(); // Clear all input fields on form load
            LoadCompanies();
            comboBoxSelectCompany.SelectedIndex = 0; // Default to the first member
        }

        private void LoadCompanies()
        {
            comboBoxSelectCompany.DataSource = _companyRepository.GetAllCompanies();
            comboBoxSelectCompany.DisplayMember = "CompanyName";
            comboBoxSelectCompany.ValueMember = "CompanyCode";
        }

        private void LoadBranches(int companyCode)
        {
            listBoxBranches.DataSource = _branchRepository.GetBranchByVisibleCompanies(companyCode);
            listBoxBranches.DisplayMember = "BranchName";
            listBoxBranches.ValueMember = "BranchCode";
            listBoxBranches.SelectedIndex = -1;
        }

        private void ClearAllFields()
        {
            textBoxBranchName.Clear();
            textBoxAddress1.Clear();
            textBoxAddress2.Clear();
            textBoxAddress3.Clear();
            textBoxAddress4.Clear();
            textBoxAddress5.Clear();
            textBoxPostCode.Clear();
            textBoxTelephoneNumber.Clear();
            textBoxFaxNumber.Clear();
            textBoxInvoiceMessage.Clear();
            textBoxCustomerLookup.Clear();
            textBoxSupplierLookup.Clear();
            comboBoxCurrencyLookup.SelectedIndex = -1;
            // Assuming there might be other combo boxes to clear
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            listBoxBranches.ClearSelected(); // Optionally clear the list box selection too
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
                branch.CurrencyLookup = Convert.ToInt32(comboBoxCurrencyLookup.Text); // TODO: Add a lookup for currency

                _branchRepository.UpdateBranch(branch);

                MessageBox.Show("Branch Updated", "Branch File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripButtonCancel_Click(sender, e);
            }
            else
            {
                var branch = new Branch
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
                    CurrencyLookup = Convert.ToInt32(comboBoxCurrencyLookup.Text), // TODO: Add a lookup for currency
                };

                _branchRepository.AddBranch(branch);
             
                MessageBox.Show("Branch Added", "Branch File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                toolStripButtonCancel_Click(sender, e);
            }
        }

        private void comboBoxSelectCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectCompany.SelectedIndex >= 0)
            {
                // Assuming the Company object has a CompanyCode property of type int
                var selectedCompany = comboBoxSelectCompany.SelectedItem as Company;
                if (selectedCompany != null)
                {
                    int companyCode = selectedCompany.CompanyCode;
                    LoadBranches(companyCode);
                }
            }
        }


        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // Deletes the selected branch from the database and refreshes the listbox
            var branch = listBoxBranches.SelectedIndex + 1;
            _branchRepository.DeleteBranch(branch);
            listBoxBranches.DataSource = _branchRepository.GetBranchByVisibleCompanies(Convert.ToInt32(comboBoxSelectCompany.SelectedIndex + 1));
            listBoxBranches.DisplayMember = "BranchName";
            listBoxBranches.ValueMember = "BranchCode";

            toolStripButtonCancel_Click(sender, e);

            MessageBox.Show("Branch Deleted", "Branch File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBranches.SelectedIndex != -1)
            {
                Branch selectedBranch = listBoxBranches.SelectedItem as Branch;
                if (selectedBranch != null)
                {
                    textBoxBranchName.Text = selectedBranch.BranchName;
                    textBoxAddress1.Text = selectedBranch.Address1;
                    textBoxAddress2.Text = selectedBranch.Address2;
                    textBoxAddress3.Text = selectedBranch.Address3;
                    textBoxAddress4.Text = selectedBranch.Address4;
                    textBoxAddress5.Text = selectedBranch.Address5;
                    textBoxPostCode.Text = selectedBranch.PostCode;
                    textBoxTelephoneNumber.Text = selectedBranch.Telephone;
                    textBoxFaxNumber.Text = selectedBranch.Fax;
                    textBoxInvoiceMessage.Text = selectedBranch.GlobalInvoiceMessage;
                    textBoxCustomerLookup.Text = selectedBranch.CustomerLookup.ToString();
                    textBoxSupplierLookup.Text = selectedBranch.SupplierLookup.ToString();
                    comboBoxCurrencyLookup.SelectedValue = selectedBranch.CurrencyLookup;
                }
                else
                {
                    ClearAllFields(); // Clears all fields if no branch is selected
                }
            }
            else
            {
                ClearAllFields(); // Clears all fields if the selection is cleared
            }
        }

        private void textBoxCustomerLookup_Leave(object sender, EventArgs e)
        {

        }
    }
}
