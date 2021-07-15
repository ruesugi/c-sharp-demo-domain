using c_sharp_demo.Domain.Repositories;
using c_sharp_demo.Domain.ValueObects;
using c_sharp_demo.Domain.Entities;
using System;
using System.ComponentModel;
using c_sharp_demo.Infrastructure;
using c_sharp_demo.Domain.Helpers;
using c_sharp_demo.Domain.Exceptions;

namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel : ViewModelBase
    {
        private IUserRepository _user;
        public UserSaveViewModel() : this(Factories.CreateUser())
        {
        }
        public UserSaveViewModel(IUserRepository user)
        {
            this._user = user;
            FreeRadioButtonChecked = true;
            EnableComboBoxSelectedValue = EnableSetting.Enable.Value;
        }

        private string _idTextBoxText = "";
        public string IdTextBoxText
        {
            get { return _idTextBoxText; }
            set
            {
                SetProperty(ref _idTextBoxText, value);
            }
        }

        private string _mailAddressTextBoxText = "";
        public string MailAddressTextBoxText
        {
            get { return _mailAddressTextBoxText; }
            set
            {
                SetProperty(ref _mailAddressTextBoxText, value);
            }
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

        public void Save()
        {
            Guard.IsNumber(IdTextBoxText, "IDは半角数字を入力してください");
            if (MailCheckBoxChecked)
            {
                if (MailAddressTextBoxText.Length == 0)
                    throw new InputException("メールアドレスを正しく入力してください");
            }

            var entity = new UserEntity(
                Convert.ToInt32(IdTextBoxText),
                MailCheckBoxChecked,
                MailAddressTextBoxText,
                PricePlan.GetPricePlan(
                    FreeRadioButtonChecked,
                    BusinessRadioButtonChecked)
                .Value,
                Convert.ToInt32(EnableComboBoxSelectedValue));
            _user.Save(entity);
        }
    }
}
