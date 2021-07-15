using c_sharp_demo.Domain.Entities;

namespace c_sharp_demo.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(UserEntity userEntity);
    }
}
