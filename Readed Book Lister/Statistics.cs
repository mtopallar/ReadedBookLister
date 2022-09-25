using Readed_Book_Lister.Entities;
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
            SetSelectionComboboxItem();
            DisableComboBoxesBySelections();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetSelectionComboboxItem()
        {
            cmbSelection.SelectedIndex = 0;
        }

        private void DisableComboBoxesBySelections()
        {
            switch (cmbSelection.SelectedItem)
            {
                case "Seçili yıl içinde":
                    MakeEnableAllComboBoxes();
                    cmbJustMonthInAYear.Enabled = false;
                    cmbBetweenTwoYears.Enabled = false;
                    break;
                case "Seçili yıldaki seçili bir ay içinde":
                    MakeEnableAllComboBoxes();
                    cmbBetweenTwoYears.Enabled = false;
                    break;
                case "Seçili yıllar arasında":
                    MakeEnableAllComboBoxes();
                    cmbJustMonthInAYear.Enabled = false;
                    break;                
            }
        }

        private void MakeEnableAllComboBoxes()
        {
            cmbJustMonthInAYear.Enabled = true;
            cmbJustAYear.Enabled = true;
            cmbBetweenTwoYears.Enabled=true;
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

