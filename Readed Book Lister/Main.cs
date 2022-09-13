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
    public partial class Main : Form
    {
        private readonly int _loggedUserId;
        public Main(int loggedUserId)
        {
            InitializeComponent();
             _loggedUserId = loggedUserId;
            MessageBox.Show(_loggedUserId.ToString());
        }      

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd(_loggedUserId);
            Hide();
            bookAdd.ShowDialog();
            Close();
        }
    }
}
