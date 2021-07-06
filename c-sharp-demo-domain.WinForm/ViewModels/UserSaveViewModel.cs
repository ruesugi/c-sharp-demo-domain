namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel : ViewModelBase
    {
        private bool _mailCheckBoxChecked = false;
        public bool MailCheckBoxChecked {
            get { return _mailCheckBoxChecked; }
            set
            {
                SetProperty(ref _mailCheckBoxChecked, value);
            } 
        }
        public bool MailAddressLabelEnabled { get; set; }
        public bool MailAddressTextBoxEnabled { get; set; }
        public object FreeRadioButtonChecked { get; set; }
        public object BusinessRadioButtonChecked { get; set; }

        public void ChangeMailAddressEnabled()
        {
            MailAddressLabelEnabled = MailCheckBoxChecked;
            MailAddressTextBoxEnabled = MailCheckBoxChecked;
        }
    }
}
