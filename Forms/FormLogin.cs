using BCrypt.Net;
using System;
using System.Drawing;
using System.Windows.Forms;
using T21.Properties;
using T21_Library.Repositories;

namespace T21.Forms
{
    public partial class FormLogin : Form
    {
        private readonly UserRepository _userRepository;

        public FormLogin(UserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.LightYellow;
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();

            textBoxUsername.Focus();
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.LightYellow;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepository.GetUserByUsername(textBoxUsername.Text);
            if (user != null)
            {
                if (!BCrypt.Net.BCrypt.Verify(textBoxPassword.Text, user.Password))
                {
                    MessageBox.Show("Invalid Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.SelectAll();
                    return;
                }
                else
                {
                    Settings.Default.LoggedInUserID = user.ID;
                    Settings.Default.DefaultCompanyID = user.DefaultCompanyLookup;
                    Settings.Default.DefaultBranchID = user.DefaultBranchLookup;
                    Settings.Default.Save();

                    DialogResult = DialogResult.OK;

                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                toolStripButtonLogin_Click(sender, e);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                toolStripButtonLogin_Click(sender, e);
            }
        }
    }
}
