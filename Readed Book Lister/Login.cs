using Readed_Book_Lister.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Image.FromFile(FileAdresses.AssetsFile + "register_hover.png");
            toolTipLogin.SetToolTip(btnRegister, "Yeni Kayıt");
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Image.FromFile(FileAdresses.AssetsFile + "register.png");
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(FileAdresses.AssetsFile + "login_hover.png");
            toolTipLogin.SetToolTip(btnLogin, "Giriş");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(FileAdresses.AssetsFile + "login.png");
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.FlatAppearance.BorderSize = 1;
            toolTipClose.SetToolTip(btnClose, "Kapat");

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.FlatAppearance.BorderSize = 0;
        }
    }
}
