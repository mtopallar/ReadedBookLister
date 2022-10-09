using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Dtos;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Methods.App_Methods;
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
    public partial class ProfileOperations : Form
    {
        private readonly User _loggedUser;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public ProfileOperations(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            SetUserNameToTextBox();
        }

        #region Helpers

        private bool CheckTextBoxValuesAreValid(params TextBox[] textBoxesToCheck)
        {
            bool flag = true;
            foreach (var currentTextBox in textBoxesToCheck)
            {
                if (!string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(currentTextBox.Text)))
                {
                    currentTextBox.BackColor = Color.Wheat;
                }
                else
                {
                    currentTextBox.BackColor = Color.FromArgb(250, 184, 187);
                    flag = false;
                }
            }
            return flag;
        }

        private bool NewPasswordAndNewPasswordAgainMustBeSame()
        {
            if (StringUtilityHelper.TrimStartAndFinish(tbxNewPassword.Text) != StringUtilityHelper.TrimStartAndFinish(tbxNewPasswordAgain.Text))
            {
                tbxNewPassword.BackColor = Color.FromArgb(250, 184, 187);
                tbxNewPasswordAgain.BackColor = Color.FromArgb(250, 184, 187);
                MessageBox.Show(Messages.NewPasswordAndNewPasswordAgainDoesNotMatch);
                return false;
            }
            tbxNewPassword.BackColor = Color.Wheat;
            tbxNewPasswordAgain.BackColor = Color.Wheat;
            return true;
        }

        private void SetUserNameToTextBox()
        {
            tbxName.Text = _loggedUser.NickName;
        }

        private void ClearTextBoxes(params TextBox[] textBoxesToClear)
        {
            foreach (var textBox in textBoxesToClear)
            {
                textBox.Text = string.Empty;
            }
        }

        private void ChangeTextBoxBackColorToNormal(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = Color.Wheat;
            }
        }

        private void ClearFormErrorsToNormalStatue()
        {
            ChangeTextBoxBackColorToNormal(tbxName, tbxCurrentPassword, tbxNewPassword, tbxNewPasswordAgain);                       
            btnUpdate.BackgroundImage = Image.FromFile(@".\assets\update_user.png");
            btnUpdate.Enabled = true;
        }

        private void ReturnToMainForm(User loggedUser)
        {
            Main mainForm = new Main(loggedUser);
            Hide();
            mainForm.ShowDialog();
            Close();
        }

        private User GetUpdatedUser()
        {
            return UserOperations.GetUserById(_loggedUser.Id);
        }

        #endregion

        #region Hovers
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

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled)
            {
                btnUpdate.BackgroundImage = Image.FromFile(@".\assets\update_user_hover.png");
                toolTipProfileOperations.SetToolTip(btnUpdate, "Profili Güncelle");
            }
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            if (btnUpdate.Enabled)
            {
                btnUpdate.BackgroundImage = Image.FromFile(@".\assets\update_user.png");
                toolTipProfileOperations.Hide(btnUpdate);
            } 
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_user_ops_hover.png");
            toolTipProfileOperations.SetToolTip(btnCancel, "Vazgeç");
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_user_ops.png");
            toolTipProfileOperations.Hide(btnCancel);
        }

        private void btnDeleteUser_MouseHover(object sender, EventArgs e)
        {
            btnDeleteUser.BackgroundImage = Image.FromFile(@".\assets\delete_hover.png");
            toolTipProfileOperations.SetToolTip(btnDeleteUser, "Profili Sil");
        }

        private void btnDeleteUser_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteUser.BackgroundImage = Image.FromFile(@".\assets\delete.png");
            toolTipProfileOperations.Hide(btnDeleteUser);
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear_user_ops_hover.png");
            toolTipProfileOperations.SetToolTip(btnClear, "Temizle");
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear_user_ops.png");
            toolTipProfileOperations.Hide(btnClear);
        }
        #endregion

        #region TextChanges

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            ClearFormErrorsToNormalStatue();
        }

        private void tbxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            ClearFormErrorsToNormalStatue();
        }

        private void tbxNewPassword_TextChanged(object sender, EventArgs e)
        {
            ClearFormErrorsToNormalStatue();
        }

        private void tbxNewPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            ClearFormErrorsToNormalStatue();
        }

        #endregion

        #region MoveForm
        private void ProfileOperations_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void ProfileOperations_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void ProfileOperations_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }

        #endregion

        #region Clicks

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValuesAreValid(tbxName, tbxCurrentPassword, tbxNewPassword, tbxNewPasswordAgain) && NewPasswordAndNewPasswordAgainMustBeSame())
            {
                UserUpdateDto userUpdateDto = new()
                {
                    Id = _loggedUser.Id,
                    NewNickName = StringUtilityHelper.TrimStartAndFinish(tbxName.Text),
                    CurrentPassword = StringUtilityHelper.TrimStartAndFinish(tbxCurrentPassword.Text),
                    NewPassword = StringUtilityHelper.TrimStartAndFinish(tbxNewPassword.Text)
                };                
                if (UserOperations.Update(userUpdateDto))
                {
                    ClearTextBoxes(tbxName, tbxCurrentPassword, tbxNewPassword, tbxNewPasswordAgain);
                    ReturnToMainForm(GetUpdatedUser());
                    return;
                }                
            }
            btnUpdate.BackgroundImage = Image.FromFile(@".\assets\update_user_error.png");
            btnUpdate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToMainForm(_loggedUser);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValuesAreValid(tbxCurrentPassword))
            {
                DialogResult dialogResult = MessageBox.Show(Messages.AreYouSureToDeleteYourProfile, "Dikkat!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    UserDeleteDto userDeleteDto = new()
                    {
                        UserId = _loggedUser.Id,
                        CurrentPassword = StringUtilityHelper.TrimStartAndFinish(tbxCurrentPassword.Text)
                        // Buraya devam edilecek. Kullanıcıdan önce userbooks tan her bir image silinmeli, sonra ilgili id den user books, en son user silinmeli. Bu yüzden user delete ve update hatta gerekirse image delete bool dönebilir. işlem sonucuna göre iç içe yürütülür. 
                    };
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormErrorsToNormalStatue();
            ClearTextBoxes(tbxCurrentPassword, tbxNewPassword, tbxNewPasswordAgain);
            tbxName.Text = _loggedUser.NickName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
