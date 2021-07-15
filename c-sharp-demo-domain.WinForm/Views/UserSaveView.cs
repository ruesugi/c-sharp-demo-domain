using c_sharp_demo.Domain.Exceptions;
using c_sharp_demo.Domain.ValueObects;
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

            IDTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.IdTextBoxText));
            MailCheckBox.DataBindings.Add(
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
            MailAddressTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MailAddressTextBoxText));
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
            NoteLabel.DataBindings.Add(
                "Visible",
                _viewModel,
                nameof(_viewModel.NoteLabelVisible));
            EnableComboBox.ValueMember = nameof(EnableSetting.Value);
            EnableComboBox.DisplayMember = nameof(EnableSetting.DisplayValue);
            EnableComboBox.DataBindings.Add(
                "SelectedValue",
                _viewModel,
                nameof(_viewModel.EnableComboBoxSelectedValue));
            EnableComboBox.DataBindings.Add(
                "DataSource",
                _viewModel,
                nameof(_viewModel.EnableSettings));
        }

        private void MailCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            MailCheckBox.DataBindings[0].WriteValue();
            _viewModel.ChangeMailAddressEnabled();
        }

        private void BusinessRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            BusinessRadioButton.DataBindings[0].WriteValue();
            _viewModel.ChangeNoteLabelVisible();
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("保存しますか？",
                                         "確認",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    _viewModel.Save();
                    StatusText.Text = "保存しました";
                }
                else
                {
                    StatusText.Text = "キャンセルしました";
                }
            }
            catch(InputException ex)
            {
                StatusText.Text = ex.Message;
            }
            
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
