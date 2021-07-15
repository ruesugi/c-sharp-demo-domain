using c_sharp_demo.WinForm;
using System;
using System.Windows.Forms;

namespace c_sharp_demo_domain.WinForm.Views
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void UserSaveViewButton_Click(object sender, EventArgs e)
        {
            using(var f = new UserSaveView())
            {
                f.ShowDialog();
            }
        }

        private void UserListViewButton_Click(object sender, EventArgs e)
        {
            using (var f = new UserListView())
            {
                f.ShowDialog();
            }
        }
    }
}
