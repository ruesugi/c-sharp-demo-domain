using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_demo.Infrastructure.Csv
{
    internal class UserCsv : IUserRepository
    {
        private readonly string _userDataPath = "user_data.csv";

        public IReadOnlyList<UserEntity> GetUser()
        {
            if (System.IO.File.Exists(_userDataPath))
            {
                var entities = new List<UserEntity>();
                var lines = System.IO.File.ReadAllLines("user_data.csv", Encoding.UTF8);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    entities.Add(new UserEntity(
                        Convert.ToInt32(data[0]), 
                        Convert.ToBoolean(data[1]), 
                        data[2], 
                        Convert.ToInt32(data[3]), 
                        Convert.ToInt32(data[4])));
                }
                return entities;
            }
            else
            {
                return null;
            }
        }

        public void Save(UserEntity userEntity)
        {
            var parameters = new List<string>
            {
                userEntity.Id.ToString(),
                userEntity.IsSending.ToString(),
                userEntity.MailAddress,
                userEntity.PricePlan.Value.ToString(),
                userEntity.EnableSetting.Value.ToString(),
            };

            CsvHelper.SaveSingle(_userDataPath, parameters);
        }
    }
}
