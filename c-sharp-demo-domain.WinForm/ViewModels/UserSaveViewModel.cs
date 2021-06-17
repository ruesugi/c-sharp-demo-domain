using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserSaveViewModel
    {
        public bool MailCheckBoxChecked { get; set; }
        public bool MailAddressLabelEnabled { get; set; }
        public bool MailAddressTextBoxEnabled { get; set; }

        public void ChangeMailAddressEnabled()
        {
            if (MailCheckBoxChecked)
            {
                MailAddressLabelEnabled = true;
                MailAddressTextBoxEnabled = true;
            }
            else
            {
                MailAddressLabelEnabled = false;
                MailAddressTextBoxEnabled = false;
            }

        }
    }
}
