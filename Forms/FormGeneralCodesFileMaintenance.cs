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
        public FormGeneralCodesFileMaintenance(CurrencyCodeRepository currencyCodeRepository)
        {
            InitializeComponent();
            _currencyCodeRepository = currencyCodeRepository;
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
                default:
                    break;
            }
        }

        private void FormGeneralCodesFileMaintenance_Load(object sender, EventArgs e)
        {

        }
    }
}
