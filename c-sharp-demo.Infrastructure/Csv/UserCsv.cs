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
            using(var sw = new System.IO.StreamWriter("user_data.csv", true, Encoding.UTF8))
            {
                sw.Write(userEntity.Id.ToString() + ",");
                sw.Write(userEntity.IsSending + ",");
                sw.Write(userEntity.MailAddress + ",");
                sw.Write(userEntity.PricePlan.Value + ",");
                sw.Write(userEntity.EnableSetting.Value);
                sw.WriteLine();
            }
        }
    }
}
