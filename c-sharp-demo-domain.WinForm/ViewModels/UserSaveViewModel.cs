﻿using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.ValueObects;
using System.ComponentModel;

namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel : ViewModelBase
    {
        public UserSaveViewModel()
        {
            foreach (var enable in EnableSetting.ToList())
            {
                EnableSettings.Add(new EnableEntity(enable.Value, enable.DisplayValue));
            }
            EnableComboBoxSelectedValue = EnableSettings[0].EnableId;
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

        public object EnableComboBoxSelectedValue { get; set; }
        public BindingList<EnableEntity> EnableSettings { get; set; }
        = new BindingList<EnableEntity>();

        public void ChangeMailAddressEnabled()
        {
            MailAddressLabelEnabled = MailCheckBoxChecked;
            MailAddressTextBoxEnabled = MailCheckBoxChecked;
        }

        public void ChangeNoteLabelVisible()
        {
            NoteLabelVisible = BusinessRadioButtonChecked;
        }
    }
}
