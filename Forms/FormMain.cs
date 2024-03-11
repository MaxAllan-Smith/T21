using System;
using System.Windows.Forms;
using T21.Forms;
using T21.Properties;
using T21_Library.Repositories;

namespace T21
{
    public partial class FormMain : Form
    {
        private readonly UserRepository _userRepository;
        private readonly BranchRepository _branchRepository;
        private readonly CompanyRepository _companyRepository;
        private readonly SupplierRepository _supplierRepository;
        private readonly CurrencyCodeRepository _currencyCodeRepository;

        public FormMain(UserRepository userRepository, BranchRepository branchRepository, CompanyRepository companyRepository, SupplierRepository supplierRepository, CurrencyCodeRepository currencyCodeRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _branchRepository = branchRepository;
            _companyRepository = companyRepository;
            _supplierRepository = supplierRepository;
            _currencyCodeRepository = currencyCodeRepository;
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            // Clear LoggedInUser Settings
            Settings.Default.LoggedInUserID = 0;
            Settings.Default.DefaultCompanyID = 0;
            Settings.Default.DefaultBranchID = 0;
            Settings.Default.Save();

            // Pre-Sets the Forms Title
            Text = "T21";

            var formLogin = new FormLogin(_userRepository);
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                var user = _userRepository.GetUserById(Settings.Default.LoggedInUserID);
                var companies = _companyRepository.GetCompanyByCompanyCode(user.DefaultCompanyLookup);
                var branches = _branchRepository.GetBranchByBranchCode(user.DefaultBranchLookup);

                Text = $"T21 - {companies.CompanyName} ({branches.BranchName})";
            }
            else
            {
                Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain_Load(sender, e);
        }

        private void userFileMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUserFileMaintenance = new FormUserFileMaintenance(_userRepository, _branchRepository, _companyRepository);
            if (formUserFileMaintenance.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void companyFileMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompanyFileMaintenance = new FormCompanyFileMaintenance(_companyRepository, _supplierRepository);
            if (formCompanyFileMaintenance.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBranchFileMaintenance = new FormBranchFileMaintenance(_branchRepository, _companyRepository);
            if (formBranchFileMaintenance.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void customerFileMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCustomerFileMaintenance = new FormCustomerFileMaintenance();
            if (formCustomerFileMaintenance.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void generalCodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formGeneralCodesFileMaintenance = new FormGeneralCodesFileMaintenance(_currencyCodeRepository);
            if (formGeneralCodesFileMaintenance.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
