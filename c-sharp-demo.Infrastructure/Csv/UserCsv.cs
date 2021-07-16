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
            var entities = new List<UserEntity>();

            foreach (var line in CsvHelper.ReadAll(_userDataPath))
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
