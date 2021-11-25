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
    public partial class formLogin : Form
    {
        Config db = new Config();
         public formLogin()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM user_info WHERE USERNAME='" + tbUsername.Text + "' AND PASSWORD ='" + tbPassword.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Success, you will login as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
