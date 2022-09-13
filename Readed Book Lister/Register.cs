using Readed_Book_Lister.App_Logics;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Dtos;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Methods.Helpers;
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
    public partial class Register : Form
    {
        User? loggedUser;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public Register()
        {
            InitializeComponent();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close_hover.png");
            tooltipClose.SetToolTip(btnClose, "Kapat");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close.png");
            tooltipClose.Hide(btnClose);
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Image.FromFile(@".\assets\register_hover.png");
            toolTipRegister.SetToolTip(btnRegister, "Kaydol");
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Image.FromFile(@".\assets\register.png");
            toolTipRegister.Hide(btnRegister);
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(@".\assets\login_hover.png");
            toolTipRegister.SetToolTip(btnLogin, "Giriş Ekranına Dön");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(@".\assets\login.png");
            toolTipRegister.Hide(btnLogin);
        }

        //My Helper Methods
        private void ErrorStatue()
        {
            tbxName.BackColor = Color.FromArgb(250, 184, 187);
            tbxPassword.BackColor = Color.FromArgb(250, 184, 187);
            tbxVerifyPassword.BackColor = Color.FromArgb(250, 184, 187);
            btnRegister.BackgroundImage = Image.FromFile(@".\assets\register_error.png");
            btnRegister.Enabled = false;
        }

        private void ClearErrorStatue()
        {
            tbxName.BackColor = Color.Wheat;
            tbxPassword.BackColor = Color.Wheat;
            tbxVerifyPassword.BackColor = Color.Wheat;
            btnRegister.BackgroundImage = Image.FromFile(@".\assets\register.png");
            btnRegister.Enabled = true;
        }
        private bool PasswordVerify()
        {

            if (StringUtilityHelper.TrimStartAndFinish(tbxPassword.Text) == StringUtilityHelper.TrimStartAndFinish(tbxVerifyPassword.Text))
            {
                return true;
            }
            MessageBox.Show(Messages.PasswordMatchError);
            return false;
        }

        private bool TextboxEmptyChecker()
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxName.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxPassword.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxVerifyPassword.Text)))
            {
                MessageBox.Show(Messages.AllFieldsAreRequired);
                return false;
            }
            return true;
        }
        //Helper methodlarımın sonu

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            Hide();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!PasswordVerify() || !TextboxEmptyChecker())
            {
                ErrorStatue();
                return;
            }
            var userToRegister = new UserLoginDto
            {
                NickName = tbxName.Text,
                Password = tbxPassword.Text                
            };

            loggedUser = AuthOperations.Register(userToRegister);
            if (loggedUser == null)
            {
                ErrorStatue();
                return;
            }
            
            Main main = new Main(loggedUser.Id);
            Hide();
            main.ShowDialog();
            Close();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        private void tbxVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        //Move Form
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }

        //Move Form Sonu
    }
}
