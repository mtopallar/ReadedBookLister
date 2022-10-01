using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister.Helpers
{
    public class CanSetReadMonthAndYearIfReadedCheckHelper
    {
        public static int? UserCanSetReadedMonthAndYearIfReadedChecked(CheckBox readedCheck, params ComboBox[] cmbToSet)
        {
            if (!readedCheck.Checked)
            {
                return null;
            }
            else
            {   
                foreach (var cmb in cmbToSet)
                {
                    if (cmb.Name == "cmbMonth" && ComboBoxMouthAndYearHelper.MonthNameToInt(cmb.Text) != 0)
                    {
                        return ComboBoxMouthAndYearHelper.MonthNameToInt(cmb.Text);
                    }
                    else if (cmb.Name == "cmbYear" && int.TryParse(cmb.Text, out int result))
                    {
                        return result;
                    }                    
                }
                return null;
            }
        }
    }
}
