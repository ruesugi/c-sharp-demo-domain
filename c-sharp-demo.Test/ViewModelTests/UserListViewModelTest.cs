using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.Repositories;
using c_sharp_demo.Domain.ValueObects;
using c_sharp_demo_domain.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace c_sharp_demo.Test.ViewModelTests
{
    [TestClass]
    public class UserListViewModelTest
    {
        [TestMethod]
        public void ユーザー情報一覧画面のテスト()
        {
            var userMock = new Mock<IUserRepository>();

            var entities = new List<UserEntity>();
            entities.Add(
                new UserEntity(
                    123,
                    true,
                    "user1@test.com",
                    0,
                    0));
            entities.Add(
                new UserEntity(
                    456,
                    false,
                    string.Empty,
                    1,
                    1));

            userMock.Setup(x => x.GetUser()).Returns(entities);

            var viewModel = new UserListViewModel(userMock.Object);

            viewModel.Users.Count.Is(2);
            viewModel.Users[0].Id.Is(123.ToString());
            viewModel.Users[0].IsSending.Is(true.ToString());
            viewModel.Users[0].MailAddress.Is("user1@test.com");
            viewModel.Users[0].PricePlan.Is("無料");
            viewModel.Users[0].EnableSetting.Is("有効");
            viewModel.Users[1].Id.Is(456.ToString());
            viewModel.Users[1].IsSending.Is(false.ToString());
            viewModel.Users[1].MailAddress.Is("");
            viewModel.Users[1].PricePlan.Is("ビジネス");
            viewModel.Users[1].EnableSetting.Is("無効");
        }
    }
}
