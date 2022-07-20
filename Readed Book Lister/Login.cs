using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            btnRegister.FlatAppearance.BorderSize = 1;
            toolTipRegister.SetToolTip(btnRegister, "Yeni Kayıt");
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.FlatAppearance.BorderSize = 0;
            
        }

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {
            btnRemove.FlatAppearance.BorderSize = 1;
            toolTipRegister.SetToolTip(btnRemove, "Kullanıcı Sil");
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRemove.FlatAppearance.BorderSize = 0;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 1;
            toolTipLogin.SetToolTip(btnLogin, "Giriş");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderSize = 0;
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
