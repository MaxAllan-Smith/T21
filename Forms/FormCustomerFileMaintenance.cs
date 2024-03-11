using System;
using System.Drawing;
using System.Windows.Forms;

namespace T21.Forms
{
    public partial class FormCustomerFileMaintenance : Form
    {
        public FormCustomerFileMaintenance()
        {
            InitializeComponent();
            RegisterFocusEvents(this.Controls);
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
