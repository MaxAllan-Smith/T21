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
                dataGridView.Rows.Add(currencyCode.Code, currencyCode.Symbol, currencyCode.Description, currencyCode.FixedOrVariable, Convert.ToDecimal(currencyCode.Rate));
            }

            // sets the datagridview to no selection
            dataGridView.ClearSelection();

            textBoxRate.Text = "0.00";
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // clears all textboxes except for textBoxLocalCurrencyCode
            textBoxCurrencyCode.Text = "";
            textBoxDescription.Text = "";
            comboBoxSymbol.SelectedIndex = -1;
            comboBoxFixedOrVariable.SelectedIndex = -1;
            textBoxRate.Text = "";
            dataGridView.ClearSelection();
            textBoxRate.Text = "0.00";

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
            dataGridView.Rows.Add(textBoxCurrencyCode.Text, comboBoxSymbol.SelectedItem.ToString(), textBoxDescription.Text, comboBoxFixedOrVariable.SelectedItem.ToString(), textBoxRate.Text);

            // updates local currency labels to what is stored in the settings
            labelLocalCurrencyCode.Text = Properties.Settings.Default.LocalCurrencyCode;
            labelLocalCurrencyName.Text = Properties.Settings.Default.LocalCurrencyDescription;
            labelLocalCurrencyPerc.Text = Properties.Settings.Default.LocalCurrencyRate.ToString();

            toolStripButtonCancel.PerformClick(); // Assuming this clears the form or closes the modal/dialog
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // updates the textboxes and comboboxes with the selected row's data
            if (dataGridView.SelectedRows.Count == 0)
            {
                toolStripButtonCancel.PerformClick();
            }
            else if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxCurrencyCode.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxSymbol.SelectedItem = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                textBoxDescription.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                comboBoxFixedOrVariable.SelectedItem = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                textBoxRate.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // checks if the selected currency code is the local currency from settings and prevents deletion
            if (dataGridView.SelectedRows[0].Cells[0].Value.ToString() == Properties.Settings.Default.LocalCurrencyCode)
            {
                MessageBox.Show("Cannot Delete Local Currency", "Currency File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyCode.Focus();
                return;
            }

            // Deletes the selected currency from the database and refreshes the datagridview
            var dataGridCurrencyCode = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            var currencyCode = _currencyCodeRepository.GetCurrencyCodeByCode(dataGridCurrencyCode);
            _currencyCodeRepository.DeleteCurrencyCode(currencyCode.ID);

            dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);

            toolStripButtonCancel.PerformClick();

            MessageBox.Show("Currency deleted", "Currency File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonMakeDefault_Click(object sender, EventArgs e)
        {
            // checks if the selected currency code is already the local currency from settings and prevents setting again
            if (dataGridView.SelectedRows[0].Cells[0].Value.ToString() == Properties.Settings.Default.LocalCurrencyCode)
            {
                MessageBox.Show("Currency is already the default local currency", "Currency File Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrencyCode.Focus();
                return;
            }

            // asks the user if they want to make the selected currency the default local currency
            var dialogResult = MessageBox.Show("Do you want to make this your default local currency?", "Set Local Currency", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.LocalCurrencyCode = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                Properties.Settings.Default.LocalCurrencyDescription = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                Properties.Settings.Default.LocalCurrencyRate = Convert.ToDecimal(dataGridView.SelectedRows[0].Cells[4].Value.ToString());
                Properties.Settings.Default.Save();

                // updates local currency labels to what is stored in the settings
                labelLocalCurrencyCode.Text = Properties.Settings.Default.LocalCurrencyCode;
                labelLocalCurrencyName.Text = Properties.Settings.Default.LocalCurrencyDescription;
                labelLocalCurrencyPerc.Text = Properties.Settings.Default.LocalCurrencyRate.ToString();
            }

            toolStripButtonCancel.PerformClick();
        }

        private void textBoxRate_Leave(object sender, EventArgs e)
        {
            // checks if the rate is a valid decimal and if not, corrects the format to a valid decimal % rate
            if (!decimal.TryParse(textBoxRate.Text, out decimal rate))
            {
                textBoxRate.Text = "0.00";
                textBoxRate.Focus();
            }
            else
            {
                textBoxRate.Text = rate.ToString("0.00");
            }
        }

        private void textBoxRate_Enter(object sender, EventArgs e)
        {
            textBoxRate.SelectAll();
        }

        private void textBoxRate_Click(object sender, EventArgs e)
        {
            textBoxRate.SelectAll();
        }
    }
}
