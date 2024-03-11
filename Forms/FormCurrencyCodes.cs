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
    public partial class FormCurrencyCodes : Form
    {
        private readonly CurrencyCodeRepository _currencyCodeRepository;
        public FormCurrencyCodes(CurrencyCodeRepository currencyCodeRepository)
        {
            InitializeComponent();
            _currencyCodeRepository = currencyCodeRepository;
        }

        private void FormCurrencyCodes_Load(object sender, EventArgs e)
        {
            // updates local currency labels to what is stored in the settings
            textBoxLocalCurrencyCode.Text = Properties.Settings.Default.LocalCurrencyCode;
            labelLocalCurrencyName.Text = Properties.Settings.Default.LocalCurrencyDescription;
            labelLocalCurrencyPerc.Text = Properties.Settings.Default.LocalCurrencyRate.ToString();

            // loads all currency codes from the database into the datagridview
            var currencyCodes = _currencyCodeRepository.GetAllCurrencyCodes();
            foreach (var currencyCode in currencyCodes)
            {
                dataGridView.Rows.Add(currencyCode.Code, currencyCode.Description, currencyCode.Symbol, currencyCode.FixedOrVariable, Convert.ToDecimal(currencyCode.Rate));
            }
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // clears all textboxes and comboboxes in form using a foreach loop
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                    ((ComboBox)control).Text = "";
                }
            }

            // sets focus to the first textbox in the form
            textBoxCurrencyCode.Focus();


        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {

            // Check for existing currency by code
            var existingCurrency = _currencyCodeRepository.GetCurrencyCodeByCode(textBoxCurrencyCode.Text);

            if (existingCurrency != null)
            {
                // Update Existing Currency Details
                existingCurrency.Code = textBoxCurrencyCode.Text;
                existingCurrency.Description = textBoxDescription.Text;
                existingCurrency.Symbol = comboBoxSymbol.SelectedItem.ToString(); // Assuming you have a textBox for Symbol
                existingCurrency.FixedOrVariable = comboBoxFixedOrVariable.SelectedItem.ToString(); // Assuming a comboBox for Fixed/Variable
                existingCurrency.Rate = Convert.ToDecimal(textBoxRate.Text);

                _currencyCodeRepository.UpdateCurrencyCode(existingCurrency);

                MessageBox.Show("Currency updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Check and Set as Default Currency if no default is set
                if (string.IsNullOrEmpty(Properties.Settings.Default.LocalCurrencyCode))
                {
                    var dialogResult = MessageBox.Show("No Default Currency Set!\nDo you want to make this your default local currency?", "Set Local Currency", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Properties.Settings.Default.LocalCurrencyCode = textBoxCurrencyCode.Text;
                        Properties.Settings.Default.LocalCurrencyDescription = textBoxDescription.Text;
                        Properties.Settings.Default.LocalCurrencyRate = Convert.ToDecimal(textBoxRate.Text);
                        Properties.Settings.Default.Save();
                    }
                }

                // Add New Currency
                var newCurrency = new CurrencyCode
                {
                    Code = textBoxCurrencyCode.Text,
                    Description = textBoxDescription.Text,
                    Symbol = comboBoxSymbol.SelectedItem.ToString(), // Assuming you have a textBox for Symbol
                    FixedOrVariable = comboBoxFixedOrVariable.SelectedItem.ToString(), // Assuming a comboBox for Fixed/Variable
                    Rate = Convert.ToDecimal(textBoxRate.Text),
                };

                _currencyCodeRepository.AddCurrencyCode(newCurrency);

                MessageBox.Show("Currency added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // add currency code to the datagridview that already has preset columns
            dataGridView.Rows.Add(textBoxCurrencyCode.Text, textBoxDescription.Text, comboBoxSymbol.SelectedItem.ToString(), comboBoxFixedOrVariable.SelectedItem.ToString(), textBoxRate.Text);

            // updates local currency labels to what is stored in the settings
            labelLocalCurrencyCode.Text = Properties.Settings.Default.LocalCurrencyCode;
            labelLocalCurrencyName.Text = Properties.Settings.Default.LocalCurrencyDescription;
            labelLocalCurrencyPerc.Text = Properties.Settings.Default.LocalCurrencyRate.ToString();

            toolStripButtonCancel.PerformClick(); // Assuming this clears the form or closes the modal/dialog
        }
    }
}
