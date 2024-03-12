using System;
using System.Drawing;
using System.Windows.Forms;
using T21_Library.Repositories;

namespace T21.Forms
{
    public partial class FormCustomerFileMaintenance : Form
    {
        private readonly CurrencyCodeRepository _currencyCodeRepository;
        private readonly VATCodeRepository _vatCodeRepository;
        private readonly SellingLevelRepository _sellingLevelRepository;
        private readonly CustomerPaymentTermsRepository _customerPaymentTermsRepository;

        public FormCustomerFileMaintenance(CurrencyCodeRepository currencyCodeRepository, VATCodeRepository vatCodeRepository, SellingLevelRepository sellingLevelRepository, CustomerPaymentTermsRepository customerPaymentTermsRepository)
        {
            InitializeComponent();
            RegisterFocusEvents(this.Controls);
            _currencyCodeRepository = currencyCodeRepository;
            _vatCodeRepository = vatCodeRepository;
            _sellingLevelRepository = sellingLevelRepository;
            _customerPaymentTermsRepository = customerPaymentTermsRepository;
        }

        private void RegisterFocusEvents(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox) // You can add || control is ComboBox etc. for other control types
                {
                    control.Enter += Control_Enter;
                    control.Leave += Control_Leave;
                }
                if (control.HasChildren)
                {
                    RegisterFocusEvents(control.Controls);
                }
            }
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
            {
                control.BackColor = Color.LightYellow; // Example selection color
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
            {
                control.BackColor = SystemColors.Window; // Reset to default color
            }
        }

        private void FormCustomerFileMaintenance_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageGeneral;

            var currencyCodes = _currencyCodeRepository.GetAllCurrencyCodes();
            foreach (var currencyCode in currencyCodes)
            {
                comboBoxCurrencyCode.Items.Add($"{currencyCode.Code} - {currencyCode.Description}");
            }
            comboBoxCurrencyCode.SelectedIndex = 0;

            var vatCodes = _vatCodeRepository.GetAll();
            foreach (var vatCode in vatCodes)
            {
                comboBoxVATCode.Items.Add($"{vatCode.Description} - {Convert.ToInt32(vatCode.VATRate)}%");
            }
            comboBoxVATCode.SelectedIndex = 0;

            var sellingLevels = _sellingLevelRepository.GetAllSellingLevels();
            foreach (var sellingLevel in sellingLevels)
            {
                comboBoxSellingLevel.Items.Add($"{sellingLevel.Description} - {Convert.ToInt32(sellingLevel.SuggestedMargin)}%");
            }
            // Set comboBoxSellingLevel to the index of the default selling level without explicitly knowing its index
            comboBoxSellingLevel.SelectedIndex = sellingLevels.FindIndex(s => s.Default);

            var customerPaymentTerms = _customerPaymentTermsRepository.GetAll();
            foreach (var customerPaymentTerm in customerPaymentTerms)
            {
                comboBoxPaymentTerms.Items.Add($"{customerPaymentTerm.Description} - " +$"{(customerPaymentTerm.DaysFromInvDate != 0 ? customerPaymentTerm.DaysFromInvDate : customerPaymentTerm.DaysFromMonthEnd)} Days");
            }
            comboBoxPaymentTerms.SelectedIndex = 0;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            textBoxAccountNumber.Focus();
        }

        private void FormCustomerFileMaintenance_Shown(object sender, EventArgs e)
        {
            textBoxAccountNumber.Focus();
        }
    }
}
