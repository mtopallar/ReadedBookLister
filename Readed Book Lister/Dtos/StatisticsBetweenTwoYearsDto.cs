using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Dtos
{
    public class StatisticsBetweenTwoYearsDto
    {
        public int Year { get; set; }
        public List<int> Counts { get; set; }

        public StatisticsBetweenTwoYearsDto()
        {
            Counts = new List<int>();
        }
    }    
}
