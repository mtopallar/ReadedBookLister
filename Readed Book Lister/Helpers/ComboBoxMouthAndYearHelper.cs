using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister.Helpers
{
    public class ComboBoxMouthAndYearHelper
    {
        public static int MonthNameToInt(string selectedMouth)
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

        public static string MonthNameFromInt(int selectedMouthNumber)
        {
            switch (selectedMouthNumber)
            {
                case 1:
                    return "Ocak";
                case 2:
                    return "Şubat";
                case 3:
                    return "Mart";
                case 4:
                    return "Nisan";
                case 5:
                    return "Mayıs";
                case 6:
                    return "Haziran";
                case 7:
                    return "Temmuz";
                case 8:
                    return "Ağustos";
                case 9:
                    return "Eylül";
                case 10:
                    return "Ekim";
                case 11:
                    return "Kasım";
                case 12:
                    return "Aralık";
                default: return "Bitirma Tarihi (Ay)";
            }
        }

        public static void CmbYearFiller(params ComboBox[] comboBoxes)
        {
            Array.ForEach(comboBoxes, x => SetCmbYearMaxDropItems(x));

            int startYear = 1930;
            foreach (ComboBox comboBox in comboBoxes)
                for (int i = DateTime.Now.Year; i >= startYear; i--)
                {
                    comboBox.Items.Add(i.ToString());
                }
        }

        #region Statistics için özel

        // İlkini bir eksik dolduran - BetweenTwoYears
        public static void CmbOneYearMinutesForBetweenTwoYears(ComboBox comboBox)
        {
            SetCmbYearMaxDropItems(comboBox);
            int startYear = 1930;
            for (int i = DateTime.Now.Year - 1; i >= startYear; i--)
            {
                comboBox.Items.Add(i.ToString());
            }
        }

        // İkinciyi ilkine göre dolduran - BetweenTwoYears
        public static void CmbBetweenTwoYearsLessDateFiller(ComboBox comboBoxFromMinToNow, int minYear)
        {
            SetCmbYearMaxDropItems(comboBoxFromMinToNow);
            for (int i = DateTime.Now.Year; i > minYear; i--)
            {
                comboBoxFromMinToNow.Items.Add(i.ToString());
            }
        }

        #endregion

        private static void SetCmbYearMaxDropItems(ComboBox comboBox)
        {
            comboBox.IntegralHeight = false;
            comboBox.MaxDropDownItems = 12;
        }
    }
}
