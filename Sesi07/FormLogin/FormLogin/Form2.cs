using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class frmRegister : Form
    {
        Config db = new Config();
            public frmRegister()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            bool isInvalid = name.Equals("") || username.Equals("") || password.Equals("");

            if (isInvalid)
            {
                tbName.Focus();
                MessageBox.Show("Data tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = "Ingin register data?";
            string caption = "Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                db.Execute("INSERT INTO user_info (names, username, password) VALUES "
                    + "('" + tbName.Text + "', '" + tbUsername.Text + "', '" + tbPassword.Text + "')"
                );
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
