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
    public partial class ProfileOperations : Form
    {
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public ProfileOperations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close_hover.png");
            toolTipClose.SetToolTip(btnClose, "Kapat");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close.png");
            toolTipClose.Hide(btnClose);
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackgroundImage = Image.FromFile(@".\assets\update_user_hover.png");
            toolTipProfileOperations.SetToolTip(btnUpdate, "Profili Güncelle");
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackgroundImage = Image.FromFile(@".\assets\update_user.png");
            toolTipProfileOperations.Hide(btnUpdate);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_user_ops_hover.png");
            toolTipProfileOperations.SetToolTip(btnCancel, "Vazgeç");
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_user_ops.png");
            toolTipProfileOperations.Hide(btnCancel);
        }

        private void btnDeleteUser_MouseHover(object sender, EventArgs e)
        {
            btnDeleteUser.BackgroundImage = Image.FromFile(@".\assets\delete_hover.png");
            toolTipProfileOperations.SetToolTip(btnDeleteUser, "Profili Sil");
        }

        private void btnDeleteUser_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteUser.BackgroundImage = Image.FromFile(@".\assets\delete.png");
            toolTipProfileOperations.Hide(btnDeleteUser);
        }

        private void ProfileOperations_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void ProfileOperations_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void ProfileOperations_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
    }
}
