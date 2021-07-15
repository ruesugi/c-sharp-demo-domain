using c_sharp_demo.Domain.Entities;
using System.Collections.Generic;

namespace c_sharp_demo.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(UserEntity userEntity);
        IReadOnlyList<UserEntity> GetUser();
    }
}
