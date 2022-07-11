using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Entities
{
    public class UserBook
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public bool Readed { get; set; }
        public bool Native { get; set; }
        public int? ReadMouth { get; set; } //Ay ve yıl => string olarak tutmak gerekebilir.
        public int? ReadYear { get; set; }
        public string Image { get; set; }
        public string Note { get; set; }
    }
}
