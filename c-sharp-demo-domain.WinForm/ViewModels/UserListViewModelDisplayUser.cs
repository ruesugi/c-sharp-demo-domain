using c_sharp_demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public sealed class UserListViewModelDisplayUser
    {
        private UserEntity _entity;
        public UserListViewModelDisplayUser(UserEntity entity)
        {
            _entity = entity;
        }

        public string Id => _entity.Id.ToString();
        public string IsSending => _entity.IsSending.ToString();
        public string MailAddress => _entity.MailAddress;
        public string PricePlan => _entity.PricePlan.DisplayValue;
        public string EnableSetting => _entity.EnableSetting.DisplayValue;
    }
}
