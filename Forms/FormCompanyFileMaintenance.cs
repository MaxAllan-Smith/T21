using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T21_Library.Models;
using T21_Library.Repositories;

namespace T21.Forms
{
    public partial class FormCompanyFileMaintenance : Form
    {
        private readonly CompanyRepository _companyRepository;
        private readonly SupplierRepository _supplierRepository;

        public FormCompanyFileMaintenance(CompanyRepository companyRepository, SupplierRepository supplierRepository)
        {
            InitializeComponent();
            _companyRepository = companyRepository;
            _supplierRepository = supplierRepository;
        }

        // Validate the form
        private bool ValidateForm()
        {
            if (textBoxCompanyName.Text == "")
            {
                MessageBox.Show("Company Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxPostCode.Text == "")
            {
                MessageBox.Show("Post Code is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxVATRegNo.Text == "")
            {
                MessageBox.Show("VAT Registration Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxCompanyRegNo.Text == "")
            {
                MessageBox.Show("Company Registration Number is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            textBoxCompanyName.Text = "";
            textBoxAddress1.Text = "";
            textBoxAddress2.Text = "";
            textBoxAddress3.Text = "";
            textBoxAddress4.Text = "";
            textBoxAddress5.Text = "";
            textBoxPostCode.Text = "";
            textBoxTelephoneNumber.Text = "";
            textBoxFaxNumber.Text = "";
            textBoxVATRegNo.Text = "";
            textBoxCompanyRegNo.Text = "";

            textBoxCompanyName.Focus();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void toolStripButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            else
            {
                var existingCompany = _companyRepository.GetCompanyByCompanyName(textBoxCompanyName.Text);

                if (existingCompany != null)
                {
                    // Update Company Details
                    existingCompany.CompanyName = textBoxCompanyName.Text;
                    existingCompany.Address1 = textBoxAddress1.Text;
                    existingCompany.Address2 = textBoxAddress2.Text;
                    existingCompany.Address3 = textBoxAddress3.Text;
                    existingCompany.Address4 = textBoxAddress4.Text;
                    existingCompany.Address5 = textBoxAddress5.Text;
                    existingCompany.PostCode = textBoxPostCode.Text;
                    existingCompany.Telephone = textBoxTelephoneNumber.Text;
                    existingCompany.Fax = textBoxFaxNumber.Text;
                    existingCompany.VATRegNo = textBoxVATRegNo.Text;
                    existingCompany.CompanyRegNo = textBoxCompanyRegNo.Text;

                    _companyRepository.UpdateCompany(existingCompany);

                    MessageBox.Show("Company updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                }
                else
                {
                    // Add New Company
                    var newCompany = new Company
                    {
                        CompanyCode = _companyRepository.GetNextCompanyCode(),
                        CompanyName = textBoxCompanyName.Text,
                        Address1 = textBoxAddress1.Text,
                        Address2 = textBoxAddress2.Text,
                        Address3 = textBoxAddress3.Text,
                        Address4 = textBoxAddress4.Text,
                        Address5 = textBoxAddress5.Text,
                        PostCode = textBoxPostCode.Text,
                        Telephone = textBoxTelephoneNumber.Text,
                        Fax = textBoxFaxNumber.Text,
                        VATRegNo = textBoxVATRegNo.Text,
                        CompanyRegNo = textBoxCompanyRegNo.Text,
                    };
                    _companyRepository.AddCompany(newCompany);

                    MessageBox.Show($"Company added successfully!\nPlease a branch for [{newCompany.CompanyName}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                }
            }
        }


        private void FormCompanyFileMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            var companies = _companyRepository.GetAllCompanies().ToList();

            if (companies.Count == 0)
            {
                MessageBox.Show("No companies found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var currentIndex = companies.FindIndex(c => c.CompanyName == textBoxCompanyName.Text);

            if (currentIndex == -1 || currentIndex == 0)
            {
                currentIndex = companies.Count - 1;
            }
            else
            {
                currentIndex--;
            }

            var company = companies[currentIndex];

            textBoxCompanyName.Text = company.CompanyName;
            textBoxAddress1.Text = company.Address1;
            textBoxAddress2.Text = company.Address2;
            textBoxAddress3.Text = company.Address3;
            textBoxAddress4.Text = company.Address4;
            textBoxAddress5.Text = company.Address5;
            textBoxPostCode.Text = company.PostCode;
            textBoxTelephoneNumber.Text = company.Telephone;
            textBoxFaxNumber.Text = company.Fax;
            textBoxVATRegNo.Text = company.VATRegNo;
            textBoxCompanyRegNo.Text = company.CompanyRegNo;
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            var companies = _companyRepository.GetAllCompanies().ToList();

            if (companies.Count == 0)
            {
                MessageBox.Show("No companies found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var currentIndex = companies.FindIndex(c => c.CompanyName == textBoxCompanyName.Text);

            if (currentIndex == -1 || currentIndex == companies.Count - 1)
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }

            var company = companies[currentIndex];

            textBoxCompanyName.Text = company.CompanyName;
            textBoxAddress1.Text = company.Address1;
            textBoxAddress2.Text = company.Address2;
            textBoxAddress3.Text = company.Address3;
            textBoxAddress4.Text = company.Address4;
            textBoxAddress5.Text = company.Address5;
            textBoxPostCode.Text = company.PostCode;
            textBoxTelephoneNumber.Text = company.Telephone;
            textBoxFaxNumber.Text = company.Fax;
            textBoxVATRegNo.Text = company.VATRegNo;
            textBoxCompanyRegNo.Text = company.CompanyRegNo;
        }
    }
}
