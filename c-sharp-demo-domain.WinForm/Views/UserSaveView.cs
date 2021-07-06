using c_sharp_demo_domain.WinForm.ViewModels;
using System.Windows.Forms;

namespace c_sharp_demo.WinForm
{
    public partial class UserSaveView : Form
    {
        private readonly UserSaveViewModel _viewModel = new UserSaveViewModel();

        public UserSaveView()
        {
            InitializeComponent();

            _mailCheckBoxBinding = MailCheckBox.DataBindings.Add(
                "Checked",
                _viewModel,
                nameof(_viewModel.MailCheckBoxChecked),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            MailAddressLabel.DataBindings.Add(
                "Enabled",
                _viewModel,
                nameof(_viewModel.MailAddressLabelEnabled));
            MailAddressTextBox.DataBindings.Add(
                "Enabled",
                _viewModel,
                nameof(_viewModel.MailAddressTextBoxEnabled));
            FreeRadioButton.DataBindings.Add(
                "Checked",
                _viewModel,
                nameof(_viewModel.FreeRadioButtonChecked),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            BusinessRadioButton.DataBindings.Add(
                "Checked",
                _viewModel,
                nameof(_viewModel.BusinessRadioButtonChecked),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private readonly Binding _mailCheckBoxBinding;

        private void MailCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            _mailCheckBoxBinding.WriteValue();
            _viewModel.ChangeMailAddressEnabled();
        }
    }
}
