using Readed_Book_Lister.App_Logics;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Dtos;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Helpers;
using Readed_Book_Lister.Methods.Helpers;
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
        User? logedUser;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        
        public Login()
        {
            InitializeComponent();
            JsonOperations.CreateDbFilesIfNot();
            DisableAcceptOrCancelButtonFrames.DisableUnvantedFrames(btnLogin,btnClose);
            JsonOperations.HideSystemFoldersAndDbFiles();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Image.FromFile(@".\assets\register_hover.png");
            toolTipLogin.SetToolTip(btnRegister, "Yeni Kayıt");

        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = Image.FromFile(@".\assets\register.png");
            toolTipLogin.Hide(btnRegister);
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(@".\assets\login_hover.png");
            toolTipLogin.SetToolTip(btnLogin, "Giriş");

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(@".\assets\login.png");
            toolTipLogin.Hide(btnLogin);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close_hover.png");
            toolTipClose.SetToolTip(btnClose, "Kapat");

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close.png");
            toolTipClose.Hide(btnClose);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!TextBoxEmptyChecker())
            {
                ErrorStatue();
                return;
            }
            var loginUserDto = new UserLoginDto
            {
                NickName = tbxName.Text,
                Password = tbxPassword.Text
            };
            logedUser = AuthOperations.Login(loginUserDto);
            if (logedUser == null)
            {
                ErrorStatue();
                return;
            }
            
            Main main = new Main(logedUser);
            Hide();
            main.ShowDialog();
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            Hide();
            registerForm.ShowDialog();
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

        // MyHelper Methods
        private void ErrorStatue()
        {
            tbxName.BackColor = Color.FromArgb(250, 184, 187);
            tbxPassword.BackColor = Color.FromArgb(250, 184, 187);
            btnLogin.BackgroundImage = Image.FromFile(@".\assets\login_error.png");
            btnLogin.Enabled = false;           
            
        }

        private void ClearErrorStatue()
        {
            tbxName.BackColor = Color.Wheat;
            tbxPassword.BackColor = Color.Wheat;
            btnLogin.BackgroundImage = Image.FromFile(@".\assets\login.png");
            btnLogin.Enabled = true;
        }

        private bool TextBoxEmptyChecker()
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxName.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxPassword.Text)))
            {                
                MessageBox.Show(Messages.AllFieldsAreRequired);
                return false;
            }
            return true;
        }

        //End of MyHelper Methods

        //Move Form
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        //End of Move Form       

    }
}
