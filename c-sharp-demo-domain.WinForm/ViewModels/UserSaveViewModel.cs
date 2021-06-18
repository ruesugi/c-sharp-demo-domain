namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel : ViewModelBase
    {
        private bool _mailCheckBoxCheced = false;
        public bool MailCheckBoxChecked {
            get { return _mailCheckBoxCheced; }
            set
            {
                SetProperty(ref _mailCheckBoxCheced, value);
            } 
        }
        public bool MailAddressLabelEnabled { get; set; }
        public bool MailAddressTextBoxEnabled { get; set; }

        public void ChangeMailAddressEnabled()
        {
            MailAddressLabelEnabled = MailCheckBoxChecked;
            MailAddressTextBoxEnabled = MailCheckBoxChecked;
        }
    }
}
