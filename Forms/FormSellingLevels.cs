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
    public partial class FormSellingLevels : Form
    {
        private readonly SellingLevelRepository _sellingLevelRepository;

        public FormSellingLevels(SellingLevelRepository sellingLevelRepository)
        {
            InitializeComponent();
            _sellingLevelRepository = sellingLevelRepository;
        }

        private void FormSellingLevels_Load(object sender, EventArgs e)
        {
            // Adds Columns to the DataGridView and sets the header text
            var sellingLevelCodeColumn = new DataGridViewTextBoxColumn { Name = "Code", HeaderText = "Code"};
            var sellingLevelDescriptionColumn = new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Description" };
            var sellingLevelDefaultColumn = new DataGridViewCheckBoxColumn { Name = "Default", HeaderText = "Default" };
            var sellingLevelMinMarginColumn = new DataGridViewTextBoxColumn { Name = "MinMargin", HeaderText = "Min. Margin" };
            var sellingLevelSuggestedColumn = new DataGridViewTextBoxColumn { Name = "SuggestedMargin", HeaderText = "Sugg. Margin" };
            var sellingLevelVATIncluColumn = new DataGridViewCheckBoxColumn { Name = "VATInclusive", HeaderText = "VAT Inclu." };

            // Set AutoSize for each column
            sellingLevelCodeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sellingLevelDescriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sellingLevelDefaultColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sellingLevelMinMarginColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sellingLevelSuggestedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sellingLevelVATIncluColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            // Add the columns to the DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] 
            { 
                sellingLevelCodeColumn, 
                sellingLevelDescriptionColumn, 
                sellingLevelDefaultColumn, 
                sellingLevelMinMarginColumn, 
                sellingLevelSuggestedColumn, 
                sellingLevelVATIncluColumn 
            });

            // Get all Selling Levels from the database and add them to the DataGridView
            var sellingLevels = _sellingLevelRepository.GetAllSellingLevels();
            foreach (var sellingLevel in sellingLevels)
            {
                dataGridView.Rows.Add(
                    sellingLevel.Code,
                    sellingLevel.Description,
                    sellingLevel.Default,
                    sellingLevel.MinimumMargin,
                    sellingLevel.SuggestedMargin,
                    sellingLevel.VATInclusive
                    );
            }

            // Set the DataGridView to read-only
            dataGridView.ReadOnly = true;

            // Clears the datagridview selection
            dataGridView.ClearSelection();

            // Sets the textBoxMinimumMargin and textBoxSuggestedMargin to 2 decimal places
            textBoxMinimumMargin.Text = "0.00";
            textBoxSuggestedMargin.Text = "0.00";
            
            // If any sellings levels in database are default, disable the Default checkbox
            if (sellingLevels.Any(s => s.Default))
            {
                checkBoxDefault.Enabled = false;
            }
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            // Closes the form
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // Clears the textboxes. comboboxes and datagridview
            textBoxCode.Clear();
            textBoxDescription.Clear();
            checkBoxDefault.Checked = false;
            textBoxMinimumMargin.Text = "0.00";
            textBoxSuggestedMargin.Text = "0.00";
            checkBoxVATInclusive.Checked = false;
            dataGridView.ClearSelection();

            // If any sellings levels in database are default, disable the Default checkbox
            if (_sellingLevelRepository.GetAllSellingLevels().Any(s => s.Default))
            {
                checkBoxDefault.Enabled = false;
            }

            // Enables the Code textbox
            textBoxCode.Enabled = true;

            // sets focus back to the Code textbox
            textBoxCode.Focus();

        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Validates the Code and Description textboxes
                if (string.IsNullOrEmpty(textBoxCode.Text) || string.IsNullOrEmpty(textBoxDescription.Text))
                {
                    MessageBox.Show("Code and Description are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Initializes a new SellingLevel object
                var sellingLevel = new SellingLevel
                {
                    Code = textBoxCode.Text,
                    Description = textBoxDescription.Text,
                    Default = checkBoxDefault.Checked,
                    MinimumMargin = Convert.ToDecimal(textBoxMinimumMargin.Text),
                    SuggestedMargin = Convert.ToDecimal(textBoxSuggestedMargin.Text),
                    VATInclusive = checkBoxVATInclusive.Checked
                };

                // Checks if the Selling Level already exists in the database and updates it if it does or adds it if it doesn't
                var sellingLevelExists = _sellingLevelRepository.GetSellingLevelByCode(sellingLevel.Code);
                if (sellingLevelExists != null)
                {
                    sellingLevelExists.Code = sellingLevel.Code;
                    sellingLevelExists.Description = sellingLevel.Description;
                    sellingLevelExists.Default = sellingLevel.Default;
                    sellingLevelExists.MinimumMargin = sellingLevel.MinimumMargin;
                    sellingLevelExists.SuggestedMargin = sellingLevel.SuggestedMargin;
                    sellingLevelExists.VATInclusive = sellingLevel.VATInclusive;

                    // Updates the Selling Level in the database
                    _sellingLevelRepository.UpdateSellingLevel(sellingLevelExists);

                    // Updates the Selling Level in the DataGridView
                    dataGridView.SelectedRows[0].Cells[0].Value = sellingLevel.Code;
                    dataGridView.SelectedRows[0].Cells[1].Value = sellingLevel.Description;
                    dataGridView.SelectedRows[0].Cells[2].Value = sellingLevel.Default;
                    dataGridView.SelectedRows[0].Cells[3].Value = sellingLevel.MinimumMargin;
                    dataGridView.SelectedRows[0].Cells[4].Value = sellingLevel.SuggestedMargin;
                    dataGridView.SelectedRows[0].Cells[5].Value = sellingLevel.VATInclusive;

                    // If any sellings levels in database are default, disable the Default checkbox
                    if (sellingLevel.Default)
                    {
                        checkBoxDefault.Enabled = false;
                    }
                }
                else
                {
                    // If any sellings levels in database are default, disable the Default checkbox
                    if (sellingLevel.Default)
                    {
                        checkBoxDefault.Enabled = false;
                    }

                    // Adds the Selling Level to the database
                    _sellingLevelRepository.AddSellingLevel(sellingLevel);

                    // Adds the Selling Level to the DataGridView
                    dataGridView.Rows.Add(
                        sellingLevel.Code,
                        sellingLevel.Description,
                        sellingLevel.Default,
                        sellingLevel.MinimumMargin,
                        sellingLevel.SuggestedMargin,
                        sellingLevel.VATInclusive
                        );
                }
            }
            catch (Exception ex)
            {
                // Shows an error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Calls the toolStripButtonCancel_Click method to clear the form
                toolStripButtonCancel_Click(sender, e);
            }
        }

        private void textBoxMinimumMargin_Leave(object sender, EventArgs e)
        {
            decimal marginValue;
            if (decimal.TryParse(textBoxMinimumMargin.Text, out marginValue))
            {
                if (marginValue < 0)
                {
                    MessageBox.Show("Minimum Margin cannot be less than 0%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    marginValue = 0;
                }
                else if (marginValue > 100)
                {
                    MessageBox.Show("Minimum Margin cannot be greater than 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    marginValue = 100;
                }

                textBoxMinimumMargin.Text = marginValue.ToString("0.00");
            }
            else
            {
                // Set to default value if conversion fails
                textBoxMinimumMargin.Text = "0.00";
            }
        }

        private void textBoxSuggestedMargin_Leave(object sender, EventArgs e)
        {
            decimal marginValue;
            if (decimal.TryParse(textBoxSuggestedMargin.Text, out marginValue))
            {
                if (marginValue < 0)
                {
                    MessageBox.Show("Suggested Margin cannot be less than 0%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    marginValue = 0;
                }
                else if (marginValue > 100)
                {
                    MessageBox.Show("Suggested Margin cannot be greater than 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    marginValue = 100;
                }

                textBoxSuggestedMargin.Text = marginValue.ToString("0.00");
            }
            else
            {
                // Set to default value if conversion fails
                textBoxSuggestedMargin.Text = "0.00";
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if a row is selected in the DataGridView
                if (dataGridView.SelectedRows.Count > 0)
                {
                    // Gets the selected Selling Level from the DataGridView
                    var sellingLevel = _sellingLevelRepository.GetSellingLevelByCode(dataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    // Deletes the Selling Level from the database
                    _sellingLevelRepository.DeleteSellingLevel(sellingLevel.ID);

                    // Removes the Selling Level from the DataGridView
                    dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);

                    // Shows a success message
                    MessageBox.Show("Selling Level Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Shows an error message
                    MessageBox.Show("Please select a Selling Level to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Shows an error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                toolStripButtonCancel.PerformClick();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checks if a row is selected in the DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the DataGridViewRow from the current click event
                var row = dataGridView.Rows[e.RowIndex];

                // Sets the textboxes and comboboxes to the selected Selling Level's values
                textBoxCode.Text = row.Cells[0].Value.ToString();
                textBoxDescription.Text = row.Cells[1].Value.ToString();
                checkBoxDefault.Checked = Convert.ToBoolean(row.Cells[2].Value);
                textBoxMinimumMargin.Text = row.Cells[3].Value.ToString();
                textBoxSuggestedMargin.Text = row.Cells[4].Value.ToString();
                checkBoxVATInclusive.Checked = Convert.ToBoolean(row.Cells[5].Value);

                // If the selected row is Default, enable the Default checkbox
                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    checkBoxDefault.Enabled = true;
                }

                // Sets focus to the Code textbox
                textBoxCode.Focus();

                // Disables the Code textbox
                textBoxCode.Enabled = false;
            }
        }

        private void textBoxMinimumMargin_Enter(object sender, EventArgs e)
        {
            textBoxMinimumMargin.SelectAll();
        }

        private void textBoxSuggestedMargin_Enter(object sender, EventArgs e)
        {
            textBoxSuggestedMargin.SelectAll();
        }

        private void textBoxMinimumMargin_Click(object sender, EventArgs e)
        {
            textBoxMinimumMargin.SelectAll();
        }

        private void textBoxSuggestedMargin_Click(object sender, EventArgs e)
        {
            textBoxSuggestedMargin.SelectAll();
        }
    }
}
