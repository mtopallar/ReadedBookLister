using Readed_Book_Lister.Dtos;
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
            ComboBoxSelectedIndexSetter(cmbSelection, cmbJustMonthInAYear, cmbJustAYear);
            cmbBetweenTwoYears.Text = DateTime.Now.Year.ToString(); //Just Text
            FillUserBookStatisticsListForStartUp();
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
                //if (cmbSelection.SelectedIndex == 1 || cmbSelection.SelectedIndex == 2)
                //{
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
                //}
                //else
                //{
                //    DataGridViewTextBoxColumn dgvMonthColumn = new DataGridViewTextBoxColumn();
                //    dgvMonthColumn.HeaderText = cmbJustMonthInAYear.Text + " " +cmbJustAYear.Text;
                //    dgvMonthColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //    dgvStatistics.Columns.Add(dgvMonthColumn);
                //}
            }
            else
            {
                DataGridViewTextBoxColumn dgvNoDataColumn = new DataGridViewTextBoxColumn();
                dgvNoDataColumn.HeaderText = "Veri yok.";
                dgvNoDataColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvStatistics.Columns.Add(dgvNoDataColumn);
            }

        }

        private void SetDgvStyle()
        {
            dgvStatistics.ShowCellToolTips = false;            
            dgvStatistics.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatistics.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatistics.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatistics.EnableHeadersVisualStyles = false;            

            if (UserBookListForStatistics != null)
            {
                dgvStatistics.RowsDefaultCellStyle.BackColor = Color.Wheat;
                dgvStatistics.BackgroundColor = Color.Wheat;
                dgvStatistics.ColumnHeadersDefaultCellStyle.BackColor = Color.Wheat;               
                dgvStatistics.RowsDefaultCellStyle.SelectionBackColor = Color.Wheat;
                dgvStatistics.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvStatistics.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;

                if (cmbSelection.SelectedIndex == 0)
                {
                    for (int i = 1; i <= 13; i++)
                    {
                        if (dgvStatistics.Rows[0].Cells[i].Value == null)
                        {                            
                            dgvStatistics.Rows[0].Cells[i].Style.BackColor = Color.LightGray;
                        }
                        else
                        {
                            dgvStatistics.Rows[0].Cells[i].Style.BackColor = Color.Wheat;
                        }
                    }
                }               
            }
            else
            {
                dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStatistics.BackgroundColor = Color.LightGray;
                dgvStatistics.RowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dgvStatistics.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvStatistics.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;                
            }
            
        }

        private void FillDgvRows()
        {
            if (UserBookListForStatistics != null && cmbSelection.SelectedIndex == 0)
            {
                var selectedMonth = ComboBoxMouthAndYearHelper.MonthNameToInt(cmbJustMonthInAYear.Text);
                var rowIndex = dgvStatistics.Rows.Add();
                dgvStatistics.Rows[rowIndex].Cells[0].Value = cmbJustAYear.Text;
                dgvStatistics.Rows[rowIndex].Cells[selectedMonth].Value = UserBookListForStatistics.Count().ToString();
            }
            else if (UserBookListForStatistics != null && cmbSelection.SelectedIndex == 1)
            {
                List<string> counts = new List<string>();
                int total = 0;
                for (int i = 1; i <= 12; i++)
                {
                    counts.Add(UserBookListForStatistics.Where(u => u.ReadMonth == i).Count().ToString());
                }

                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dgvStatistics.Rows.Add(dataGridViewRow);

                dataGridViewRow.Cells[0].Value = cmbJustAYear.Text;

                for (int i = 1; i <= counts.Count; i++)
                {
                    dataGridViewRow.Cells[i].Value = counts[i - 1];
                    total += Convert.ToInt32(counts[i - 1]);
                }
                dataGridViewRow.Cells[13].Value = total.ToString();

            }
            else if (UserBookListForStatistics != null && cmbSelection.SelectedIndex == 2)
            {
                List<StatisticsBetweenTwoYearsDto> statisticsBetweenTwoYearsDtoList = new List<StatisticsBetweenTwoYearsDto>();

                for (int i = Convert.ToInt32(cmbJustAYear.Text); i <= Convert.ToInt32(cmbBetweenTwoYears.Text); i++)
                {
                    StatisticsBetweenTwoYearsDto statisticsBetweenTwoYearsDto = new();
                    statisticsBetweenTwoYearsDto.Year = i;

                    for (int j = 1; j <= 12; j++)
                    {
                        var total = UserBookListForStatistics.Where(u => u.ReadYear == i && u.ReadMonth == j).ToList().Count();

                        statisticsBetweenTwoYearsDto.Counts.Add(total);
                    }

                    statisticsBetweenTwoYearsDtoList.Add(statisticsBetweenTwoYearsDto);
                }

                var reOrderedList = statisticsBetweenTwoYearsDtoList.OrderByDescending(u => u.Year).ToList();
                for (int i = 0; i < reOrderedList.Count; i++)
                {
                    int total = 0;

                    #region Alternatif kullanıma örnek
                    //dgvStatistics.Rows.Add();
                    //DataGridViewRow dataGridViewRow = dgvStatistics.Rows[i];
                    #endregion

                    var result = dgvStatistics.Rows.Add();
                    DataGridViewRow dataGridViewRow = dgvStatistics.Rows[result];

                    dataGridViewRow.Cells[0].Value = reOrderedList[i].Year.ToString();

                    for (int j = 0; j <= 11; j++)
                    {
                        dataGridViewRow.Cells[j + 1].Value = reOrderedList[i].Counts[j].ToString();
                        total += reOrderedList[i].Counts[j];
                    }
                    dataGridViewRow.Cells[13].Value = total.ToString();
                }

            }
            else
            {
                dgvStatistics.Rows.Add("Seçilen aralıkta veri yok");
            }
            SetDgvStyle();
        }

        private void ClearDgv()
        {
            dgvStatistics.Columns.Clear();
            dgvStatistics.Rows.Clear();
        }

        #endregion

        private void cmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelection.SelectedIndex == 0) // Seçili Bir Ay İçin İstatistik
            {
                CreateDataGridViewColums();
                FillDgvRows();
                //
                ComboBoxActivator(cmbJustMonthInAYear, cmbJustAYear);
                CmbFillerForJustOneYear();
                ComboBoxSelectedIndexSetter(cmbJustMonthInAYear);
                //


            }
            else if (cmbSelection.SelectedIndex == 1) //Seçili Bir Yıl İçin İstatistik
            {
                ComboBoxActivator(cmbJustAYear);
                CmbFillerForJustOneYear();
            }
            else // Seçili Yıllar Arasında İstatistik
            {
                ComboBoxActivator(cmbJustAYear, cmbBetweenTwoYears);
                CmbJustYearFillerForBetweenTwoYears(); //ortadakini dolduran
                CmbBetweenFillerForBetweenTwoYears(); // sağdakini dolduran
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
            ClearDgv();
            ReFillUserBooksListByCmbSelections();
            CreateDataGridViewColums();
            FillDgvRows();
        }

        private void cmbJustAYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbJustAYear.Enabled)
            {
                if (cmbBetweenTwoYears.Enabled)
                {
                    CmbBetweenFillerForBetweenTwoYears();  // Just year ın durumuna göre two years yeniden dolduruluyor.
                }
            }

            ClearDgv();
            ReFillUserBooksListByCmbSelections();
            CreateDataGridViewColums();
            FillDgvRows();
        }

        private void cmbBetweenTwoYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDgv();
            ReFillUserBooksListByCmbSelections();
            CreateDataGridViewColums();
            FillDgvRows();
        }

        private void FillUserBookStatisticsListForStartUp()
        {
            UserBookListForStatistics = UserBookOperations.GetAllByReadMouthYearAndUserId(_loggedUser.Id, ComboBoxMouthAndYearHelper.MonthNameToInt(cmbJustMonthInAYear.Text), Convert.ToInt32(cmbJustAYear.Text));
        }

        private void ReFillUserBooksListByCmbSelections()
        {
            if (cmbSelection.SelectedIndex == 0)
            {
                //sol ve orta aktif
                UserBookListForStatistics = UserBookOperations.GetAllByReadMouthYearAndUserId(_loggedUser.Id, ComboBoxMouthAndYearHelper.MonthNameToInt(cmbJustMonthInAYear.Text), Convert.ToInt32(cmbJustAYear.Text));
            }
            else if (cmbSelection.SelectedIndex == 1)
            {
                //sadece orta aktif
                UserBookListForStatistics = UserBookOperations.GetAllByJustReadYearAndUserId(_loggedUser.Id, Convert.ToInt32(cmbJustAYear.Text));
            }
            else
            {
                //orta ve sağ aktif
                UserBookListForStatistics = UserBookOperations.GetUserBooksBetweenSelectedYears(_loggedUser.Id, Convert.ToInt32(cmbJustAYear.Text), Convert.ToInt32(cmbBetweenTwoYears.Text));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main(_loggedUser);
            Hide();
            mainForm.ShowDialog();
            Close();
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_hover.png");
            toolTipStatistics.SetToolTip(btnCancel, "Vazgeç");
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel.png");
            toolTipStatistics.Hide(btnCancel);
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
    }
}

