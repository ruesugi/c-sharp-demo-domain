using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.Repositories;
using c_sharp_demo.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo_domain.WinForm.ViewModels
{
    public class UserListViewModel : ViewModelBase
    {
        private IUserRepository _user;

        public UserListViewModel() : this(Factories.CreateUser())
        {
        }
        public UserListViewModel(IUserRepository user)
        {
            _user = user;
        }

        public BindingList<UserEntity> Users =
            new BindingList<UserEntity>();
    }
}
