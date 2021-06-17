using c_sharp_demo_domain.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace c_sharp_demo.Test.ViewModelTests
{
    [TestClass]
    public class UserSaveViewModelTest
    {
        [TestMethod]
        public void メールを送信するにチェックがあるときだけメールアドレスが入力できることのテスト()
        {
            var viewModel = new UserSaveViewModel();

            viewModel.MailCheckBoxChecked.Is(false);
            viewModel.MailAddressLabelEnabled.Is(false);
            viewModel.MailAddressTextBoxEnabled.Is(false);

            viewModel.MailCheckBoxChecked = true;
            viewModel.ChangeMailAddressEnabled();

            viewModel.MailAddressLabelEnabled.Is(true);
            viewModel.MailAddressTextBoxEnabled.Is(true);
        }
    }
}
