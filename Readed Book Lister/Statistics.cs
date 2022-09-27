using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Helpers;
using Readed_Book_Lister.Methods.App_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister
{
    public partial class Statistics : Form
    {
        private readonly User _loggedUser;
        private List<UserBook>? UserBookListForStatistics;
        public Statistics(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            cmbSelection.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Dgv

        private void CreateDataGridViewColums()
        {
            if (UserBookListForStatistics != null)
            {


                if (cmbSelection.SelectedIndex == 0 || cmbSelection.SelectedIndex == 2)
                {
                    DataGridViewTextBoxColumn dgvPlaceByYearColumn = new DataGridViewTextBoxColumn();
                    dgvPlaceByYearColumn.HeaderText = "Yıl";
                    dgvPlaceByYearColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvJanuaryColumn = new DataGridViewTextBoxColumn();
                    dgvJanuaryColumn.HeaderText = "Ocak";
                    dgvJanuaryColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvFebruaryColumn = new DataGridViewTextBoxColumn();
                    dgvFebruaryColumn.HeaderText = "Şubat";
                    dgvFebruaryColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvMarchColumn = new DataGridViewTextBoxColumn();
                    dgvMarchColumn.HeaderText = "Mart";
                    dgvMarchColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvAprilColumn = new DataGridViewTextBoxColumn();
                    dgvAprilColumn.HeaderText = "Nisan";
                    dgvAprilColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvMayColumn = new DataGridViewTextBoxColumn();
                    dgvMayColumn.HeaderText = "Mayıs";
                    dgvMayColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvJuneColumn = new DataGridViewTextBoxColumn();
                    dgvJuneColumn.HeaderText = "Haziran";
                    dgvJuneColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvJulyColumn = new DataGridViewTextBoxColumn();
                    dgvJulyColumn.HeaderText = "Temmuz";
                    dgvJulyColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvAugustColumn = new DataGridViewTextBoxColumn();
                    dgvAugustColumn.HeaderText = "Ağustos";
                    dgvAugustColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvSeptemberColumn = new DataGridViewTextBoxColumn();
                    dgvSeptemberColumn.HeaderText = "Eylül";
                    dgvSeptemberColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvOctoberColumn = new DataGridViewTextBoxColumn();
                    dgvOctoberColumn.HeaderText = "Ekim";
                    dgvOctoberColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvNovemberColumn = new DataGridViewTextBoxColumn();
                    dgvNovemberColumn.HeaderText = "Kasım";
                    dgvNovemberColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvDecemberColumn = new DataGridViewTextBoxColumn();
                    dgvDecemberColumn.HeaderText = "Aralık";
                    dgvDecemberColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewTextBoxColumn dgvTotalColumn = new DataGridViewTextBoxColumn();
                    dgvTotalColumn.HeaderText = "Toplam";
                    dgvTotalColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvStatistics.Columns.Add(dgvPlaceByYearColumn);
                    dgvStatistics.Columns.Add(dgvJanuaryColumn);
                    dgvStatistics.Columns.Add(dgvFebruaryColumn);
                    dgvStatistics.Columns.Add(dgvMarchColumn);
                    dgvStatistics.Columns.Add(dgvAprilColumn);
                    dgvStatistics.Columns.Add(dgvMayColumn);
                    dgvStatistics.Columns.Add(dgvJuneColumn);
                    dgvStatistics.Columns.Add(dgvJulyColumn);
                    dgvStatistics.Columns.Add(dgvAugustColumn);
                    dgvStatistics.Columns.Add(dgvSeptemberColumn);
                    dgvStatistics.Columns.Add(dgvOctoberColumn);
                    dgvStatistics.Columns.Add(dgvNovemberColumn);
                    dgvStatistics.Columns.Add(dgvDecemberColumn);
                    dgvStatistics.Columns.Add(dgvTotalColumn);
                }
                else
                {
                    DataGridViewTextBoxColumn dgvMonthColumn = new DataGridViewTextBoxColumn();
                    dgvMonthColumn.HeaderText = cmbJustMonthInAYear.SelectedText;
                    dgvMonthColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvStatistics.Columns.Add(dgvMonthColumn);
                }
            }
            else
            {
                DataGridViewTextBoxColumn dgvNoDataColumn = new DataGridViewTextBoxColumn();
                dgvNoDataColumn.HeaderText = "Veri yok.";
                dgvNoDataColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvStatistics.Columns.Add(dgvNoDataColumn);
            }
        }

        private void FillDgvRows()
        {
            if (UserBookListForStatistics != null)
            {

            }
            if (cmbSelection.SelectedIndex == 0)
            {

                if (UserBookListForStatistics == null)
                {
                    dgvStatistics.Rows.Add("Bu dönem kayıtlı kitabınız bulunmamaktadır.");
                }
                else
                {
                    dgvStatistics.Rows.Add("yıl burda olcak");
                }

            }
        }

        private void ClearDgvColumns()
        {
            dgvStatistics.Columns.Clear();
            dgvStatistics.Refresh();
        }

        #endregion

        // disablelar halledildi. two years da ortadaki mevcut yılın bir eksiğine, sağdaki ise soldakinden başlayıp günümüze kadar geliyor.
        //dgv ve kitap getir dendiğinde gelen hata mesajları handle edilecek.

        private void cmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelection.SelectedIndex == 0) // Seçili Bir Ay İçin İstatistik
            {
                ComboBoxActivator(cmbJustMonthInAYear,cmbJustAYear);
                CmbFillerForJustOneYear();
                ComboBoxSelectedIndexSetter(cmbJustMonthInAYear);
            }
            else if (cmbSelection.SelectedIndex == 1) //Seçili Bir Yıl İçin İstatistik
            {
                ComboBoxActivator(cmbJustAYear);
                CmbFillerForJustOneYear();
            }
            else // Seçili Yıllar Arasında İstatistik
            {
                ComboBoxActivator(cmbJustAYear,cmbBetweenTwoYears);
                CmbJustYearFillerForBetweenTwoYears();
                CmbBetweenFillerForBetweenTwoYears();
            }
        }

        private void CmbFillerForJustOneYear()
        {
            cmbJustAYear.Items.Clear();
            ComboBoxMouthAndYearHelper.CmbYearFiller(cmbJustAYear);
            ComboBoxSelectedIndexSetter(cmbJustAYear);
        }

        private void CmbJustYearFillerForBetweenTwoYears()
        {
            cmbJustAYear.Items.Clear();
            ComboBoxMouthAndYearHelper.CmbOneYearMinutesForBetweenTwoYears(cmbJustAYear);
            ComboBoxSelectedIndexSetter(cmbJustAYear);
        }

        private void CmbBetweenFillerForBetweenTwoYears()
        {
            cmbBetweenTwoYears.Items.Clear();            
            ComboBoxMouthAndYearHelper.CmbBetweenTwoYearsLessDateFiller(cmbBetweenTwoYears, Convert.ToInt32(cmbJustAYear.SelectedItem));
            ComboBoxSelectedIndexSetter(cmbBetweenTwoYears);
        }

        private void ComboBoxSelectedIndexSetter(params ComboBox[] comboBoxes)
        {
            Array.ForEach(comboBoxes, c => c.SelectedIndex = 0);
        }

        private void ComboBoxActivator(params ComboBox[] comboBoxToSetActive)
        {
            List<ComboBox> comboBoxesInArea = new() { cmbJustMonthInAYear, cmbJustAYear, cmbBetweenTwoYears };

            foreach (var item in comboBoxesInArea)
            {
                if (!comboBoxToSetActive.Contains(item))
                {
                    item.Enabled = false;
                }
                else
                {
                    item.Enabled = true;
                }
            }
        }

        private void cmbSelection_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbJustMonthInAYear_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbJustAYear_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbBetweenTwoYears_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbJustMonthInAYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJustMonthInAYear.Enabled && cmbJustAYear.Enabled)
            {
                UserBookListForStatistics = UserBookOperations.GetAllByReadMouthYearAndUserId(_loggedUser.Id, ComboBoxMouthAndYearHelper.MonthNameToInt(cmbJustMonthInAYear.SelectedText), Convert.ToInt32(cmbJustAYear.Text));
            }

        }

        private void cmbJustAYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbJustAYear.Enabled)
            {
                if (cmbBetweenTwoYears.Enabled)
                {
                    // Just year ın durumuna göre two years yeniden dolduruluyor.
                    CmbBetweenFillerForBetweenTwoYears();
                }

                UserBookListForStatistics = UserBookOperations.GetAllByJustReadYearAndUserId(_loggedUser.Id, Convert.ToInt32(cmbJustAYear.Text));
            }
        }

        private void cmbBetweenTwoYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBetweenTwoYears.Enabled && cmbJustAYear.Enabled)
            {
                UserBookListForStatistics = UserBookOperations.GetUserBooksBetweenSelectedYears(_loggedUser.Id, Convert.ToInt32(cmbJustAYear.Text), Convert.ToInt32(cmbBetweenTwoYears.Text));
            }

        }

    }
}

