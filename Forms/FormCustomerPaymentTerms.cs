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
    public partial class FormCustomerPaymentTerms : Form
    {
        private readonly CustomerPaymentTermsRepository _customerPaymentTermsRepository;

        public FormCustomerPaymentTerms(CustomerPaymentTermsRepository customerPaymentTermsRepository)
        {
            InitializeComponent();
            _customerPaymentTermsRepository = customerPaymentTermsRepository;
        }

        private void FormCustomerPaymentTerms_Load(object sender, EventArgs e)
        {
            // Add Columns to the DataGridView and Set their Headers
            var code = new DataGridViewTextBoxColumn { Name = "Code", HeaderText = "Code" };
            var description = new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Description" };
            var daysFromInvDate = new DataGridViewTextBoxColumn { Name = "DaysFromInvDate", HeaderText = "Days From Inv Date" };
            var daysFromMonthEnd = new DataGridViewTextBoxColumn { Name = "DaysFromMonthEnd", HeaderText = "Days From Month End" };

            // Set AutoSize For Each Column
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            daysFromInvDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            daysFromMonthEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            // Add Columns to the DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] 
            { 
                code, 
                description, 
                daysFromInvDate, 
                daysFromMonthEnd 
            });

            // Gets All Customer Payment Terms from the Database and Adds them to the DataGridView
            var customerPaymentTerms = _customerPaymentTermsRepository.GetAll();
            foreach (var customerPaymentTerm in customerPaymentTerms)
            {
                dataGridView.Rows.Add(
                    customerPaymentTerm.Code, 
                    customerPaymentTerm.Description, 
                    customerPaymentTerm.DaysFromInvDate, 
                    customerPaymentTerm.DaysFromMonthEnd
                    );
            }

            // Sets the DataGridView to ReadOnly
            dataGridView.ReadOnly = true;

            // Clears the Selection
            dataGridView.ClearSelection();

            // Sets the textBoxDaysFromInvDate and textBoxDaysFromMonthEnd to int
            textBoxDaysFromInvDate.Text = "0";
            textBoxDaysFromMonthEnd.Text = "0";

        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            // Clears the textBoxes
            textBoxCode.Text = "";
            textBoxDescription.Text = "";
            textBoxDaysFromInvDate.Text = "0";
            textBoxDaysFromMonthEnd.Text = "0";

            // Clears the Selection
            dataGridView.ClearSelection();

            // Sets Focus to the textBoxCode
            textBoxCode.Focus();
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Validates the textBoxes
                if (string.IsNullOrWhiteSpace(textBoxCode.Text))
                {
                    throw new Exception("Code is required.");
                }
                if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
                {
                    throw new Exception("Description is required.");
                }
                if (!int.TryParse(textBoxDaysFromInvDate.Text, out int daysFromInvDate))
                {
                    throw new Exception("Days From Inv Date must be a number.");
                }
                if (!int.TryParse(textBoxDaysFromMonthEnd.Text, out int daysFromMonthEnd))
                {
                    throw new Exception("Days From Month End must be a number.");
                }

                // Initializes a new CustomerPaymentTerm
                var customerPaymentTerm = new CustomerPaymentTerm
                {
                    Code = textBoxCode.Text,
                    Description = textBoxDescription.Text,
                    DaysFromInvDate = daysFromInvDate,
                    DaysFromMonthEnd = daysFromMonthEnd
                };

                // Checks if a customer payment term with the same code already exists
                var existingCustomerPaymentTerm = _customerPaymentTermsRepository.Get(customerPaymentTerm.Code);
                if (existingCustomerPaymentTerm != null)
                {
                    // Updates the existing customer payment term
                    _customerPaymentTermsRepository.Update(customerPaymentTerm);

                    // Updates the DataGridView
                    dataGridView.SelectedRows[0].Cells["Code"].Value = customerPaymentTerm.Code;
                    dataGridView.SelectedRows[0].Cells["Description"].Value = customerPaymentTerm.Description;
                    dataGridView.SelectedRows[0].Cells["DaysFromInvDate"].Value = customerPaymentTerm.DaysFromInvDate;
                    dataGridView.SelectedRows[0].Cells["DaysFromMonthEnd"].Value = customerPaymentTerm.DaysFromMonthEnd;

                    // Clears the Selection
                    dataGridView.ClearSelection();

                    // Sets Focus to the textBoxCode
                    textBoxCode.Focus();

                    return;
                }
                else
                {
                    // Adds a new customer payment term
                    _customerPaymentTermsRepository.Add(customerPaymentTerm);

                    // Adds the new customer payment term to the DataGridView
                    dataGridView.Rows.Add(
                        customerPaymentTerm.Code,
                        customerPaymentTerm.Description,
                        customerPaymentTerm.DaysFromInvDate,
                        customerPaymentTerm.DaysFromMonthEnd
                        );

                    // Clears the Selection
                    dataGridView.ClearSelection();

                    // Sets Focus to the textBoxCode
                    textBoxCode.Focus();

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                toolStripButtonCancel.PerformClick();
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // Checks if a row is selected
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            // Gets the selected customer payment term
            var customerPaymentTerm = _customerPaymentTermsRepository.Get(dataGridView.SelectedRows[0].Cells["Code"].Value.ToString());

            // Deletes the selected customer payment term
            _customerPaymentTermsRepository.Delete(customerPaymentTerm.ID);

            // Removes the selected customer payment term from the DataGridView
            dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);

            // Clears the Selection
            dataGridView.ClearSelection();

            // Clears the textBoxes
            toolStripButtonCancel.PerformClick();

            // Sets Focus to the textBoxCode
            textBoxCode.Focus();

            return;
        }

        private void textBoxDaysFromInvDate_Enter(object sender, EventArgs e)
        {
            // Selects the textBoxDaysFromInvDate
            textBoxDaysFromInvDate.SelectAll();
        }

        private void textBoxDaysFromInvDate_Leave(object sender, EventArgs e)
        {
            // Validates the textBoxDaysFromInvDate and sets it to 0 if it's empty
            if (string.IsNullOrWhiteSpace(textBoxDaysFromInvDate.Text))
            {
                textBoxDaysFromInvDate.Text = "0";
            }
        }

        private void textBoxDaysFromMonthEnd_Enter(object sender, EventArgs e)
        {
            // Selects the textBoxDaysFromMonthEnd
            textBoxDaysFromMonthEnd.SelectAll();
        }

        private void textBoxDaysFromMonthEnd_Leave(object sender, EventArgs e)
        {
            // Validates the textBoxDaysFromMonthEnd and sets it to 0 if it's empty
            if (string.IsNullOrWhiteSpace(textBoxDaysFromMonthEnd.Text))
            {
                textBoxDaysFromMonthEnd.Text = "0";
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checks if a row is selected
            if (dataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            // Sets the textBoxes to the selected customer payment term
            textBoxCode.Text = dataGridView.SelectedRows[0].Cells["Code"].Value.ToString();
            textBoxDescription.Text = dataGridView.SelectedRows[0].Cells["Description"].Value.ToString();
            textBoxDaysFromInvDate.Text = dataGridView.SelectedRows[0].Cells["DaysFromInvDate"].Value.ToString();
            textBoxDaysFromMonthEnd.Text = dataGridView.SelectedRows[0].Cells["DaysFromMonthEnd"].Value.ToString();

            // Sets Focus to the textBoxCode
            textBoxCode.Focus();

            return;
        }
    }
}
