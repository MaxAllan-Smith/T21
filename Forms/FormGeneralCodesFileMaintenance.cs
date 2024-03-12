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
    public partial class FormGeneralCodesFileMaintenance : Form
    {
        private readonly CurrencyCodeRepository _currencyCodeRepository;
        private readonly VATCodeRepository _vatCodeRepository;
        private readonly SellingLevelRepository _sellingLevelRepository;
        private readonly CustomerPaymentTermsRepository _customerPaymentTermsRepository;

        public FormGeneralCodesFileMaintenance(CurrencyCodeRepository currencyCodeRepository, VATCodeRepository vatCodeRepository, SellingLevelRepository sellingLevelRepository, CustomerPaymentTermsRepository customerPaymentTermsRepository)
        {
            InitializeComponent();
            _currencyCodeRepository = currencyCodeRepository;
            _vatCodeRepository = vatCodeRepository;
            _sellingLevelRepository = sellingLevelRepository;
            _customerPaymentTermsRepository = customerPaymentTermsRepository;
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            switch (listBox.SelectedItem.ToString())
            {
                case "Currency Codes":
                    var formCurrencyCodes = new FormCurrencyCodes(_currencyCodeRepository);
                    if (formCurrencyCodes.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                    break;
                case "VAT Codes":
                    var formVATCodes = new FormVATCodes(_vatCodeRepository);
                    if (formVATCodes.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                    break;
                case "Selling Levels":
                    var formSellingLevels = new FormSellingLevels(_sellingLevelRepository);
                    if (formSellingLevels.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                    break;
                case "Payment Terms - Customer":
                    var formCustomerPaymentTerms = new FormCustomerPaymentTerms(_customerPaymentTermsRepository);
                    if (formCustomerPaymentTerms.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                    break;
                default:
                    break;
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            switch (listBox.SelectedItem.ToString())
            {
                case "Currency Codes":
                    var formCurrencyCodes = new FormCurrencyCodes(_currencyCodeRepository);
                    if (formCurrencyCodes.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                    break;
                case "VAT Codes":
                    var formVATCodes = new FormVATCodes(_vatCodeRepository);
                    if (formVATCodes.ShowDialog() == DialogResult.OK)
                    {

                    }
                    break;
                case "Selling Levels":
                    var formSellingLevels = new FormSellingLevels(_sellingLevelRepository);
                    if (formSellingLevels.ShowDialog() == DialogResult.OK)
                    {

                    }
                    break;
                default:
                    break;
            }
        }

        private void FormGeneralCodesFileMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
        }
    }
}
