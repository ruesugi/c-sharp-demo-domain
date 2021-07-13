using c_sharp_demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(UserEntity userEntity);
    }
}
