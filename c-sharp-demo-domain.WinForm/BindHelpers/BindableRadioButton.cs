using System;
using System.Windows.Forms;

namespace c_sharp_demo_domain.WinForm.BindHelpers
{
    public sealed class BindableRadioButton : RadioButton
    {
        public BindableRadioButton()
        {
            AutoCheck = false;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            this.Checked = !this.Checked;
        }
    }
}
