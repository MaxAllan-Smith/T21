using Microsoft.Extensions.Logging;
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
    public partial class FormVATCodes : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly VATCodeRepository _vatCodeRepository;

        public FormVATCodes(VATCodeRepository vatCodeRepository)
        {
            InitializeComponent();
            _vatCodeRepository = vatCodeRepository;
        }

        private void FormVATCodes_Load(object sender, EventArgs e)
        {
            // Adds Columns to the DataGridView and sets the Header Text
            var vatCodeColumn = new DataGridViewTextBoxColumn { Name = "VATCode", HeaderText = "VAT Code" };
            var vatDescriptionColumn = new DataGridViewTextBoxColumn { Name = "VATDescription", HeaderText = "VAT Description" };
            var vatRateColumn = new DataGridViewTextBoxColumn { Name = "VATRate", HeaderText = "VAT Rate %" };
            var eecMemberColumn = new DataGridViewTextBoxColumn { Name = "EECMember", HeaderText = "EEC Member" };
            var eecTaxRateColumn = new DataGridViewTextBoxColumn { Name = "EECTaxRate", HeaderText = "EEC Tax Rate %" };

            // Set AutoSizeMode for each column
            vatCodeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vatDescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vatRateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            eecMemberColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            eecTaxRateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Add the columns to the DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { vatCodeColumn, vatDescriptionColumn, vatRateColumn, eecMemberColumn, eecTaxRateColumn });

            // Gets all the VAT Codes from the Database and adds them to the DataGridView
            var vatCodes = _vatCodeRepository.GetAll();
            foreach (var vatCode in vatCodes)
            {
                dataGridView.Rows.Add(vatCode.Code, vatCode.Description, vatCode.VATRate, vatCode.EECMember, vatCode.EECTaxRate);
            }

            // Sets the DataGridView to ReadOnly
            dataGridView.ReadOnly = true;

            // Clears the selection from the DataGridView
            dataGridView.ClearSelection();

            // Set the textBoxVATRate and textBoxEECTaxRate with a default value of 0.00 and 0.00 as decimal
            textBoxVATRate.Text = "0.00";
            textBoxEECTaxRate.Text = "0.00";

            // Sets the comboBoxEECMember with the values "Yes" and "No" and sets the default value to "No"
            comboBoxEECMember.Items.Add("Yes");
            comboBoxEECMember.Items.Add("No");
            comboBoxEECMember.SelectedIndex = 1;


        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // Clears all textboxes, sets textBoxVATRate and textBoxEECTaxRate to 0.00 and comboBoxEECMember to "No"
            textBoxCode.Text = "";
            textBoxDescription.Text = "";
            textBoxVATRate.Text = "0.00";
            comboBoxEECMember.SelectedIndex = 1;
            textBoxEECTaxRate.Text = "0.00";

            // Sets focus to the textBoxCode
            textBoxCode.Focus();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a row and not the column header
            if (e.RowIndex >= 0)
            {
                // Get the DataGridViewRow from the current click event
                var row = dataGridView.Rows[e.RowIndex];

                // Set the values to the textboxes and combobox
                textBoxCode.Text = row.Cells["VATCode"].Value.ToString();
                textBoxDescription.Text = row.Cells["VATDescription"].Value.ToString();
                textBoxVATRate.Text = row.Cells["VATRate"].Value.ToString();
                comboBoxEECMember.SelectedItem = row.Cells["EECMember"].Value.ToString().Equals("Yes") ? "Yes" : "No";
                textBoxEECTaxRate.Text = row.Cells["EECTaxRate"].Value.ToString();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // Removes the selected row from the Database and if successful, removes the selected row from the DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                var code = dataGridView.SelectedRows[0].Cells["VATCode"].Value.ToString();
                if (_vatCodeRepository.DeleteByCode(code))
                {
                    dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                }

            }

            // Clears all textboxes, sets textBoxVATRate and textBoxEECTaxRate to 0.00 and comboBoxEECMember to "No"
            toolStripButtonCancel.PerformClick();
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCode.Text) || string.IsNullOrEmpty(textBoxDescription.Text) || string.IsNullOrEmpty(textBoxEECTaxRate.Text))
                {
                    MessageBox.Show("VAT Code, VAT Description and VAT Rate are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var vatCode = new VATCode
                {
                    Code = textBoxCode.Text,
                    Description = textBoxDescription.Text,
                    VATRate = Convert.ToDecimal(textBoxVATRate.Text),
                    EECMember = comboBoxEECMember.SelectedItem.ToString(),
                    EECTaxRate = Convert.ToDecimal(textBoxEECTaxRate.Text)
                };

                // Attempt to save the VAT Code
                if (_vatCodeRepository.SaveVATCode(vatCode))
                {
                    // If save was successful, add the VAT Code to the DataGridView
                    dataGridView.Rows.Add(vatCode.Code, vatCode.Description, vatCode.VATRate, vatCode.EECMember, vatCode.EECTaxRate);
                    logger.Info("VAT Code saved successfully.");
                }
                else
                {
                    MessageBox.Show("This VAT Code is already in use with a different record. Please use a different code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Failed to save VAT Code due to duplicate code.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the VAT Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error(ex, "An exception occurred while saving VAT Code.");
            }
            finally
            {
                // Reset UI elements or perform cleanup here
                toolStripButtonCancel.PerformClick();
                logger.Info("Finished processing toolStripButtonOK_Click.");
            }
        }

        private void textBoxVATRate_Leave(object sender, EventArgs e)
        {
            // Format the textBoxVATRate to 2 decimal places
            textBoxVATRate.Text = string.Format("{0:0.00}", Convert.ToDecimal(textBoxVATRate.Text));

            // If the textBoxVATRate is empty, set the value to 0.00
            if (string.IsNullOrEmpty(textBoxVATRate.Text))
            {
                textBoxVATRate.Text = "0.00";
            }

            // If the textBoxVATRate is greater than 100, set the value to 100.00
            if (Convert.ToDecimal(textBoxVATRate.Text) > 100)
            {
                // Alerts the user that the VAT Rate cannot be greater than 100
                MessageBox.Show("VAT Rate cannot be greater than 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Sets the value to 100.00
                textBoxVATRate.Text = "100.00";
            }

            // If the textBoxVATRate is less than 0, set the value to 0.00
            if (Convert.ToDecimal(textBoxVATRate.Text) < 0)
            {
                textBoxVATRate.Text = "0.00";
            }
        }

        private void textBoxEECTaxRate_Leave(object sender, EventArgs e)
        {
            // Format the textBoxEECTaxRate to 2 decimal places
            textBoxEECTaxRate.Text = string.Format("{0:0.00}", Convert.ToDecimal(textBoxEECTaxRate.Text));

            // If the textBoxEECTaxRate is empty, set the value to 0.00
            if (string.IsNullOrEmpty(textBoxEECTaxRate.Text))
            {
                textBoxEECTaxRate.Text = "0.00";
            }

            // If the textBoxEECTaxRate is greater than 100, set the value to 100.00
            if (Convert.ToDecimal(textBoxEECTaxRate.Text) > 100)
            {
                // Alerts the user that the EEC Tax Rate cannot be greater than 100
                MessageBox.Show("EEC Tax Rate cannot be greater than 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Sets the value to 100.00
                textBoxEECTaxRate.Text = "100.00";
            }

            // If the textBoxEECTaxRate is less than 0, set the value to 0.00
            if (Convert.ToDecimal(textBoxEECTaxRate.Text) < 0)
            {
                textBoxEECTaxRate.Text = "0.00";
            }
        }
    }
}
