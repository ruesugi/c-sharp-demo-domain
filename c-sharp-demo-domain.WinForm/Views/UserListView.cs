using c_sharp_demo_domain.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_demo_domain.WinForm.Views
{
    public partial class UserListView : Form
    {
        private readonly UserListViewModel _viewModel = new UserListViewModel();
        public UserListView()
        {
            InitializeComponent();

            UserDataGrid.DataBindings.Add(
                "DataSource",
                _viewModel,
                nameof(_viewModel.Users));
        }
    }
}
