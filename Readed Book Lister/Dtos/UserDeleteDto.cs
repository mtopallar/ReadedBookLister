using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Dtos
{
    public class UserDeleteDto
    {
        public int UserId { get; set; }
        public string CurrentPassword { get; set; }
    }
}
