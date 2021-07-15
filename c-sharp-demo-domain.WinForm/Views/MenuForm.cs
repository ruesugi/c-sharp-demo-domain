using c_sharp_demo.WinForm;
using System;
using System.Windows.Forms;

namespace c_sharp_demo_domain.WinForm.Views
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void UserSaveFormButton_Click(object sender, EventArgs e)
        {
            using(var f = new UserSaveView())
            {
                f.ShowDialog();
            }
        }
    }
}
