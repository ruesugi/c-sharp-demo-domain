namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel : ViewModelBase
    {
        private bool _mailCheckBoxChecked = false;
        public bool MailCheckBoxChecked
        {
            get { return _mailCheckBoxChecked; }
            set
            {
                SetProperty(ref _mailCheckBoxChecked, value);
            }
        }
        public bool MailAddressLabelEnabled { get; set; }
        public bool MailAddressTextBoxEnabled { get; set; }

        private bool _freeRadioButtonChecked = false;
        public bool FreeRadioButtonChecked
        {
            get { return _freeRadioButtonChecked; }
            set
            {
                SetProperty(ref _freeRadioButtonChecked, value);
            }
        }

        private bool _businnesRadioButtonChecked = false;
        public bool BusinessRadioButtonChecked
        {
            get { return _businnesRadioButtonChecked; }
            set
            {
                SetProperty(ref _businnesRadioButtonChecked, value);
            }
        }

        public void ChangeMailAddressEnabled()
        {
            MailAddressLabelEnabled = MailCheckBoxChecked;
            MailAddressTextBoxEnabled = MailCheckBoxChecked;
        }
    }
}
