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
    public partial class BookAdd : Form
    {

        public BookAdd()
        {
            InitializeComponent();
            CmbYearFiller();
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

        private void cbxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxYear.Checked)
            {
                cmbMonth.Text = "Bitirme Tarihi (Ay)";
                cmbYear.Text = "Bitirme Tarihi (Yıl)";
                cmbMonth.Enabled = false;
                cmbYear.Enabled = false;
                cbxMonth.Enabled = false;
            }
            else
            {
                cmbMonth.Enabled = true;
                cmbYear.Enabled = true;
                cbxMonth.Checked = false;
                cbxMonth.Enabled = true;
            }
        }

        private void cbxMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMonth.Checked)
            {
                cmbMonth.Text = "Bitirme Tarihi (Ay)";
                cmbMonth.Enabled = false;
            }
            else
            {
                cmbMonth.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!FormControlsErrorChecker())
            {
                SetErrorStatue();
                return;
            }
            MessageBox.Show("Hata yok");
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

        private void cbxMonth_MouseHover(object sender, EventArgs e)
        {
            cbxMonth.Image = Image.FromFile(@".\assets\month_hover.png");
            toolTipAddBook.SetToolTip(cbxMonth, "Ayı Hatırlamıyorum");
        }

        private void cbxMonth_MouseLeave(object sender, EventArgs e)
        {
            cbxMonth.Image = Image.FromFile(@".\assets\month.png");
            toolTipAddBook.Hide(cbxMonth);
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
            cbxMonth.Checked = false;
            cmbMonth.SelectedIndex = -1;
            cmbMonth.Text = "Bitirme Tarihi (Ay)";
            cmbYear.SelectedIndex = -1;
            cmbYear.Text = "Bitirme Tarihi (Yıl)";
        }

        private int MonthNameToInt(string selectedMouth)
        {
            switch (selectedMouth)
            {
                case "Ocak":
                    return 1;
                case "Şubat":
                    return 2;
                case "Mart":
                    return 3;
                case "Nisan":
                    return 4;
                case "Mayıs":
                    return 5;
                case "Haziran":
                    return 6;
                case "Temmuz":
                    return 7;
                case "Ağustos":
                    return 8;
                case "Eylül":
                    return 9;
                case "Ekim":
                    return 10;
                case "Kasım":
                    return 11;
                case "Aralık":
                    return 12;
                default: return 0;
            }
        }


        private void CmbYearFiller()
        {
            int startYear = 1700;

            for (int i = DateTime.Now.Year; i >= startYear; i--)
            {
                cmbYear.Items.Add(i.ToString());
            }
        }

        private void SetErrorStatue()
        {
            MessageBox.Show("Hata var.");
            //ad, yazar ve tarih alanlarının arka rengini pembe, kaydet butonunu hata resmi yap. (tarihi ay ve yıla göre ayarla)
        }

        private void ClearErrorStatue()
        {

        }

        private bool FormControlsErrorChecker()
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxName.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxAuthor.Text)) || !DateTimeActiveButNotSelectedChecker())
            {
                return false;
            }
            return true;
        }

        private bool DateTimeActiveButNotSelectedChecker()
        {

            if (!cmbMonth.Enabled && cmbYear.Enabled && !int.TryParse(cmbYear.Text, out _))
            {
                return false;
            }
            
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (MonthNameToInt(cmbMonth.Text) == 0 || !int.TryParse(cmbYear.Text, out _)))
            {
                return false;
            }

            return true;
        }



        #endregion


    }
}
