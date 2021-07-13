using c_sharp_demo.Domain.Repositories;
using c_sharp_demo.Domain.ValueObects;
using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Infrastructure.Csv;
using System;
using System.ComponentModel;

namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel : ViewModelBase
    {
        private IUserRepository _user;
        public UserSaveViewModel() : this(new UserCsv())
        {
        }
        public UserSaveViewModel(IUserRepository user)
        {
            this._user = user;
            EnableComboBoxSelectedValue = EnableSetting.Enable.Value;
        }

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
        public void ChangeMailAddressEnabled()
        {
            MailAddressLabelEnabled = MailCheckBoxChecked;
            MailAddressTextBoxEnabled = MailCheckBoxChecked;
        }

        private bool _freeRadioButtonChecked = false;
        public bool FreeRadioButtonChecked
        {
            get { return _freeRadioButtonChecked; }
            set
            {
                SetProperty(ref _freeRadioButtonChecked, value);

                if (value)
                {
                    SetProperty(
                        ref _businnesRadioButtonChecked,
                        false,
                        nameof(BusinessRadioButtonChecked));
                }
            }
        }
        private bool _businnesRadioButtonChecked = false;
        public bool BusinessRadioButtonChecked
        {
            get { return _businnesRadioButtonChecked; }
            set
            {
                SetProperty(ref _businnesRadioButtonChecked, value);

                if (value)
                {
                    SetProperty(
                        ref _freeRadioButtonChecked,
                        false,
                        nameof(FreeRadioButtonChecked));
                }
            }
        }
        private bool _noteLabelVisible = false;

        public bool NoteLabelVisible
        {
            get { return _noteLabelVisible; }
            set
            {
                SetProperty(ref _noteLabelVisible, value);
            }
        }
        public void ChangeNoteLabelVisible()
        {
            NoteLabelVisible = BusinessRadioButtonChecked;
        }

        public object EnableComboBoxSelectedValue { get; set; }
        public BindingList<EnableSetting> EnableSettings { get; set; }
        = new BindingList<EnableSetting>(EnableSetting.ToList());

        public string IdTextBoxText { get; set; }
        public string MailAddressTextBoxText { get; set; }

        public void Save()
        {
            var entity = new UserEntity(
                123,
                true,
                "user1@test.com",
                0,
                0);
            _user.Save(entity);
        }
    }
}
