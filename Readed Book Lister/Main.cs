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
    public partial class Main : Form
    {
        private readonly User _loggedUser;
        public Main(User loggedUser)
        {
            InitializeComponent();
             _loggedUser = loggedUser;
            MessageBox.Show(_loggedUser.Id.ToString());
        }      

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd(_loggedUser);
            Hide();
            bookAdd.ShowDialog();
            Close();
        }
    }
}
