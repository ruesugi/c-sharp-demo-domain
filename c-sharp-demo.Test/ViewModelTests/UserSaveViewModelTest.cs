using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.Exceptions;
using c_sharp_demo.Domain.Repositories;
using c_sharp_demo_domain.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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

            viewModel.FreeRadioButtonChecked.Is(true);
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

        [TestMethod]
        public void 保存ボタンが押されたときに入力データが保存されることのテスト()
        {
            var userMock = new Mock<IUserRepository>();

            var viewModel = new UserSaveViewModel(userMock.Object);

            viewModel.IdTextBoxText = "123";
            viewModel.MailCheckBoxChecked = true;
            viewModel.MailAddressTextBoxText = "user1@test.com";
            viewModel.FreeRadioButtonChecked = true;
            viewModel.EnableComboBoxSelectedValue = 0;

            userMock.Setup(x => x.Save(It.IsAny<UserEntity>()))
                .Callback<UserEntity>(saveValue =>
                {
                    saveValue.Id.Is(123);
                    saveValue.IsSending.Is(true);
                    saveValue.MailAddress.Is("user1@test.com");
                    saveValue.PricePlan.Value.Is(0);
                    saveValue.EnableSetting.Value.Is(0);
                });

            viewModel.Save();

            viewModel.IdTextBoxText = "456";
            viewModel.MailCheckBoxChecked = true;
            viewModel.MailAddressTextBoxText = "user2@test.com";
            viewModel.BusinessRadioButtonChecked = true;
            viewModel.EnableComboBoxSelectedValue = 1;

            userMock.Setup(x => x.Save(It.IsAny<UserEntity>()))
                .Callback<UserEntity>(saveValue =>
                {
                    saveValue.Id.Is(456);
                    saveValue.IsSending.Is(true);
                    saveValue.MailAddress.Is("user2@test.com");
                    saveValue.PricePlan.Value.Is(1);
                    saveValue.EnableSetting.Value.Is(1);
                });

            viewModel.Save();
            userMock.VerifyAll();
        }

        [TestMethod]
        public void メールを送信するのチェックがないときの保存処理のテスト()
        {
            var userMock = new Mock<IUserRepository>();

            var viewModel = new UserSaveViewModel(userMock.Object);
            viewModel.IdTextBoxText = "123";
            viewModel.MailCheckBoxChecked = false;
            viewModel.MailAddressTextBoxText = "user1@test.com";
            viewModel.FreeRadioButtonChecked = true;
            viewModel.EnableComboBoxSelectedValue = 0;

            userMock.Setup(x => x.Save(It.IsAny<UserEntity>()))
                .Callback<UserEntity>(saveValue =>
                {
                    saveValue.Id.Is(123);
                    saveValue.IsSending.Is(false);
                    saveValue.MailAddress.Is("");
                    saveValue.PricePlan.Value.Is(0);
                    saveValue.EnableSetting.Value.Is(0);
                });

            viewModel.Save();

            viewModel.IdTextBoxText = "123";
            viewModel.MailCheckBoxChecked = true;
            viewModel.MailAddressTextBoxText = "user1@test.com";
            viewModel.FreeRadioButtonChecked = true;
            viewModel.EnableComboBoxSelectedValue = 0;

            userMock.Setup(x => x.Save(It.IsAny<UserEntity>()))
                .Callback<UserEntity>(saveValue =>
                {
                    saveValue.Id.Is(123);
                    saveValue.IsSending.Is(true);
                    saveValue.MailAddress.Is("user1@test.com");
                    saveValue.PricePlan.Value.Is(0);
                    saveValue.EnableSetting.Value.Is(0);
                });

            viewModel.Save();
            userMock.VerifyAll();
        }

        [TestMethod]
        public void 入力欄に不正な文字が含まれていた場合に例外を発生するテスト()
        {
            var viewModel = new UserSaveViewModel();

            var ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("IDは半角数字を入力してください");

            viewModel.IdTextBoxText = "abc";
            ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("IDは半角数字を入力してください");

            viewModel.IdTextBoxText = ",./@-^\\]";
            ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("IDは半角数字を入力してください");

            viewModel.IdTextBoxText = "0,a./1@-^\\2]";
            ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("IDは半角数字を入力してください");

            viewModel.IdTextBoxText = "123";
            viewModel.MailCheckBoxChecked = true;
            ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("メールアドレスを正しく入力してください");

            viewModel.MailAddressTextBoxText = "suzuki.example.com";
            ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("メールアドレスを正しく入力してください");

            viewModel.MailAddressTextBoxText = "sato#suzuki@example.com";
            ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("メールアドレスを正しく入力してください");
        }
    }
}
