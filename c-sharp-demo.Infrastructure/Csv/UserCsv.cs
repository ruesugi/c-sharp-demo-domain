using c_sharp_demo.Domain.Entities;
using c_sharp_demo.Domain.Repositories;
using System.Collections.Generic;

namespace c_sharp_demo.Infrastructure.Csv
{
    internal class UserCsv : IUserRepository
    {
        private readonly string _userDataPath = "user_data.csv";

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
