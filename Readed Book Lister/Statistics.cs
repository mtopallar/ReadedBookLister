using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Helpers;
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
    public partial class Statistics : Form
    {
        private readonly User _loggedUser;
        public Statistics(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;            
            DisableComboBoxesBySelections();
            ComboBoxMouthAndYearHelper.CmbYearFiller(cmbJustAYear, cmbBetweenTwoYears);                    
            cmbSelection.SelectedIndex = 0;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetSelectionOfComboBoxes()
        {            
            cmbJustAYear.SelectedIndex = 0;
            cmbJustMonthInAYear.SelectedIndex = 0;
            cmbBetweenTwoYears.SelectedIndex = 0;
        }
        
        private void DisableComboBoxesBySelections()
        {
            switch (cmbSelection.SelectedItem)
            {
                case "Seçili yıl içinde":
                    MakeEnableAllComboBoxes();
                    ClearIncludedCmbData();                    
                    ComboBoxMouthAndYearHelper.CmbYearFiller(cmbJustAYear, cmbBetweenTwoYears);
                    SetSelectionOfComboBoxes();
                    cmbJustMonthInAYear.Enabled = false;
                    cmbBetweenTwoYears.Enabled = false;
                    break;
                case "Seçili yıldaki seçili bir ay içinde":
                    MakeEnableAllComboBoxes();
                    ClearIncludedCmbData();                    
                    ComboBoxMouthAndYearHelper.CmbYearFiller(cmbJustAYear, cmbBetweenTwoYears);
                    SetSelectionOfComboBoxes();
                    cmbBetweenTwoYears.Enabled = false;
                    break;
                case "Seçili yıllar arasında":
                    MakeEnableAllComboBoxes();
                    ClearIncludedCmbData();                    
                    ComboBoxMouthAndYearHelper.CmbYearFiller(cmbJustAYear, cmbBetweenTwoYears);
                    cmbJustAYear.Items.Remove(DateTime.Now.Year.ToString());                    
                    SetSelectionOfComboBoxes();
                    cmbJustMonthInAYear.Enabled = false;
                    break;
            }
        }
                        
        private void ClearIncludedCmbData()
        {
            cmbJustAYear.Items.Clear();
            cmbBetweenTwoYears.Items.Clear();
            cmbBetweenTwoYears.Refresh();
            cmbJustAYear.Refresh();
        }

        private void MakeEnableAllComboBoxes()
        {
            cmbJustMonthInAYear.Enabled = true;
            cmbJustAYear.Enabled = true;
            cmbBetweenTwoYears.Enabled = true;
        }

        private void cmbSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableComboBoxesBySelections();
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
    }
}

