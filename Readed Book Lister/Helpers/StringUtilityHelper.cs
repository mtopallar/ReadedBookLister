﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Methods.Helpers
{
    public class StringUtilityHelper
    {
        public static string TrimStartAndFinish(string entry)
        {
            var editedStart = entry.TrimStart();
            var editedFinishentry = editedStart.TrimEnd();
            return editedFinishentry;
        }

        public static string ToTrLocaleTitleCase(string entry)
        {
            var toLoverCase = entry.ToLower();
            TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
            var editedText = textInfo.ToTitleCase(toLoverCase);
            return editedText;
        }

        public static string ToEngLocaleTitleCase(string entry)
        {
            var toLoverCase = entry.ToLower();
            var engText = StringReplace(toLoverCase);
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            var editedText = textInfo.ToTitleCase(engText);
            return editedText;
        }
       

        private static string StringReplace(string entry)
        {
            entry = entry.Replace("İ", "I");
            entry = entry.Replace("ı", "i");
            entry = entry.Replace("Ğ", "G");
            entry = entry.Replace("ğ", "g");
            entry = entry.Replace("Ö", "O");
            entry = entry.Replace("ö", "o");
            entry = entry.Replace("Ü", "U");
            entry = entry.Replace("ü", "u");
            entry = entry.Replace("Ş", "S");
            entry = entry.Replace("ş", "s");
            entry = entry.Replace("Ç", "C");
            entry = entry.Replace("ç", "c");
            return entry;
        }
    }
}

