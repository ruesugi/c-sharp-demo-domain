using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
