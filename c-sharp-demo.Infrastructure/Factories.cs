using c_sharp_demo.Domain.Repositories;
using c_sharp_demo.Infrastructure.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo.Infrastructure
{
    public static class Factories
    {
        public static IUserRepository CreateUser()
        {
            return new UserCsv();
        }
    }
}
