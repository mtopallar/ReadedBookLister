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
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
        }

        
        #region Clicks

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
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

        private void btnBrowse_MouseHover(object sender, EventArgs e)
        {
            btnBrowse.BackgroundImage = Image.FromFile(@".\assets\browse_hover.png");
            toolTipAddBook.SetToolTip(btnBrowse, "Gözat");
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.BackgroundImage = Image.FromFile(@".\assets\browse.png");
            toolTipAddBook.Hide(btnBrowse);
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear_hover.png");
            toolTipAddBook.SetToolTip(btnClear, "Temizle");
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear.png");
            toolTipAddBook.Hide(btnClear);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_hover.png");
            toolTipAddBook.SetToolTip(btnCancel, "Vazgeç");
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel.png");
            toolTipAddBook.Hide(btnCancel);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save_hover.png");
            toolTipAddBook.SetToolTip(btnSave, "Kaydet");
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
            toolTipAddBook.Hide(btnSave);
        }

        private void cbxYear_MouseHover(object sender, EventArgs e)
        {
            cbxYear.Image = Image.FromFile(@".\assets\date_remember_hover.png");
            toolTipAddBook.SetToolTip(cbxYear, "Tarihi Hatırlamıyorum");
        }

        private void cbxYear_MouseLeave(object sender, EventArgs e)
        {
            cbxYear.Image = Image.FromFile(@".\assets\date_remember.png");
            toolTipAddBook.Hide(cbxYear);
        }

        private void cbxReaded_MouseHover(object sender, EventArgs e)
        {
            cbxReaded.Image = Image.FromFile(@".\assets\completed_hover.png");
            toolTipAddBook.SetToolTip(cbxReaded, "Okudum");
        }

        private void cbxReaded_MouseLeave(object sender, EventArgs e)
        {
            cbxReaded.Image = Image.FromFile(@".\assets\completed.png");
            toolTipAddBook.Hide(cbxReaded);
        }

        private void cbxNative_MouseHover(object sender, EventArgs e)
        {
            cbxNative.Image = Image.FromFile(@".\assets\native_hover.png");
            toolTipAddBook.SetToolTip(cbxNative, "Yerli Kitap");
        }

        private void cbxNative_MouseLeave(object sender, EventArgs e)
        {
            cbxNative.Image = Image.FromFile(@".\assets\native.png");
            toolTipAddBook.Hide(cbxNative);
        }
        #endregion

        #region Helpers

        private void ClearControls()
        {
            tbxName.Text = string.Empty;
            tbxAuthor.Text = string.Empty;
            tbxImage.Text = string.Empty;
            tbxNote.Text = string.Empty;
            cbxNative.Checked = false;
            cbxReaded.Checked = false;
            cbxYear.Checked = false;
            cmbMouth.SelectedIndex = -1;
            cmbMouth.Text = "Bitirme Tarihi (Ay)";
            cmbYear.SelectedIndex = -1;
            cmbYear.Text = "Bitirme Tarihi (Yıl)";

        }

        #endregion

        
    }
}
