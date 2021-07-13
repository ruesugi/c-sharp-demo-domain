using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo.Infrastructure.Csv
{
    public class UserCsv : IUserRepository
    {
        public void Save(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }
    }
}
