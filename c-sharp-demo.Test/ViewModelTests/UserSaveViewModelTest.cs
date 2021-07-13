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

            viewModel.MailCheckBoxChecked = false;
            viewModel.ChangeMailAddressEnabled();

            viewModel.MailAddressLabelEnabled.Is(false);
            viewModel.MailAddressTextBoxEnabled.Is(false);
        }

        [TestMethod]
        public void 料金プランの選択ができることのテスト()
        {
            var viewModel = new UserSaveViewModel();

            viewModel.FreeRadioButtonChecked.Is(false);
            viewModel.BusinessRadioButtonChecked.Is(false);
            viewModel.NoteLabelVisible.Is(false);

            viewModel.FreeRadioButtonChecked = true;
            viewModel.BusinessRadioButtonChecked.Is(false);
            viewModel.NoteLabelVisible.Is(false);

            viewModel.BusinessRadioButtonChecked = true;
            viewModel.FreeRadioButtonChecked.Is(false);
            viewModel.ChangeNoteLabelVisible();
            viewModel.NoteLabelVisible.Is(true);

            viewModel.FreeRadioButtonChecked = true;
            viewModel.BusinessRadioButtonChecked.Is(false);
            viewModel.ChangeNoteLabelVisible();
            viewModel.NoteLabelVisible.Is(false);
        }

        [TestMethod]
        public void 起動時にComboBoxに有効と無効がされていることのテスト()
        {
            var viewModel = new UserSaveViewModel();

            viewModel.EnableSettings.Count.Is(2);
            viewModel.EnableSettings[0].DisplayValue.Is("有効");
            viewModel.EnableSettings[1].DisplayValue.Is("無効");
            viewModel.EnableComboBoxSelectedValue.Is(0);
        }
    }
}
