using Sunglasses_Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_PRN211_FA23_1237778_NguyenQuocThien
{
    public partial class Login : Form
    {
        AccountRepo accountRepo;
        public Login()
        {
            InitializeComponent();
            accountRepo = new AccountRepo();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var Password = txtPassword.Text;
            var user = accountRepo.GetAll().Where(x => x.MemberEmail.Equals(email) && x.MemberAccountPassword.Equals(Password)).FirstOrDefault();
            if (user != null)
            {
                if (user.Role == 2)
                {
                    this.Hide();
                    SunglassForm Sunglass = new SunglassForm();
                    Sunglass.Show();
                }
                else if (user.Role == 3)
                {
                    this.Hide();
                    SunglassForm Sunglass = new SunglassForm();
                    Sunglass.Show();
                }
                else
                {
                    MessageBox.Show("You Have No Permission To Access This Function!");
                }
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
