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
    public partial class FormUserFileMaintenance : Form
    {
        private readonly UserRepository _userRepository;
        private readonly BranchRepository _branchRepository;
        private readonly CompanyRepository _companyRepository;

        public FormUserFileMaintenance(UserRepository userRepository, BranchRepository branchRepository, CompanyRepository companyRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _branchRepository = branchRepository;
            _companyRepository = companyRepository;
        }

        private void ClearFormFields()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            comboBoxDefaultCompany.SelectedIndex = -1;
            comboBoxDefaultBranch.SelectedIndex = -1;
        }

        private void FormUserFileMaintenance_Load(object sender, EventArgs e)
        {
            // ComboBoxDefaultBranch Disabled On Load
            comboBoxDefaultBranch.Enabled = false;

            // Load Companies to Company ComboBox
            var companies = _companyRepository.GetAllCompanies();
            comboBoxDefaultCompany.DisplayMember = "CompanyName";
            comboBoxDefaultCompany.ValueMember = "CompanyCode";
            comboBoxDefaultCompany.DataSource = companies.ToList();

            // Set ComboBoxes to Default
            comboBoxDefaultCompany.SelectedIndex = -1;
            comboBoxDefaultBranch.DataSource = null;
            comboBoxDefaultBranch.Enabled = false;
        }


        private void comboBoxDefaultCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDefaultCompany.SelectedIndex != -1)
            {
                int selectedCompanyCode = Convert.ToInt32(comboBoxDefaultCompany.SelectedValue);

                var branches = _branchRepository.GetBranchByVisibleCompanies(selectedCompanyCode).ToList();

                comboBoxDefaultBranch.DataSource = null;
                comboBoxDefaultBranch.DisplayMember = "BranchName";
                comboBoxDefaultBranch.ValueMember = "BranchCode";

                comboBoxDefaultBranch.DataSource = branches;

                comboBoxDefaultBranch.Enabled = branches.Count > 0;

                if (branches.Count > 0)
                {
                    comboBoxDefaultBranch.SelectedIndex = -1;
                }
            }
            else
            {
                comboBoxDefaultBranch.DataSource = null;
                comboBoxDefaultBranch.Enabled = false;
            }
        }


        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // Clear All TextBoxes
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            // Set ComboBoxes to Default
            comboBoxDefaultCompany.SelectedIndex = -1;
            comboBoxDefaultBranch.SelectedIndex = -1;

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            var user = _userRepository.GetUserByUsername(textBoxUsername.Text);

            if (user != null)
            {
                textBoxUsername.Text = user.UserName;
                textBoxPassword.Text = user.Password;
                textBoxFirstName.Text = user.FirstName;
                textBoxLastName.Text = user.LastName;
                comboBoxDefaultCompany.SelectedValue = user.DefaultCompanyLookup;
                comboBoxDefaultBranch.SelectedValue = user.DefaultBranchLookup;
            }
        }

        private void toolStripButtonSubmit_Click(object sender, EventArgs e)
        {
            var existingUser = _userRepository.GetUserByUsername(textBoxUsername.Text);

            if (existingUser != null)
            {
                existingUser.Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text); 
                existingUser.FirstName = textBoxFirstName.Text;
                existingUser.LastName = textBoxLastName.Text;
                existingUser.DefaultCompanyLookup = Convert.ToInt32(comboBoxDefaultCompany.SelectedValue);
                existingUser.DefaultBranchLookup = Convert.ToInt32(comboBoxDefaultBranch.SelectedValue);

                _userRepository.UpdateUser(existingUser);

                MessageBox.Show("User Updated Successfully", "User File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var newUser = new User
                {
                    UserName = textBoxUsername.Text,
                    Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text),
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    DefaultCompanyLookup = Convert.ToInt32(comboBoxDefaultCompany.SelectedValue),
                    DefaultBranchLookup = Convert.ToInt32(comboBoxDefaultBranch.SelectedValue)
                };

                _userRepository.AddUser(newUser);

                MessageBox.Show("User Added Successfully", "User File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Clear All TextBoxes and Reset ComboBoxes
            ClearFormFields();

            textBoxUsername.Focus();
        }
    }
}
