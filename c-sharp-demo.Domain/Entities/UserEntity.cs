using c_sharp_demo.Domain.ValueObects;

namespace c_sharp_demo.Domain.Entities
{
    public sealed class UserEntity
    {
        public UserEntity(
            int id,
            bool isSending,
            string mailAddress,
            int pricePlan,
            int enableSetting)
        {
            Id = id;
            IsSending = isSending;
            _mailAddress = mailAddress;
            PricePlan = new PricePlan(pricePlan);
            EnableSetting = new EnableSetting(enableSetting);
        }

        public int Id { get; }
        public bool IsSending { get; }
        private readonly string _mailAddress;
        public string MailAddress
        {
            get { return IsSending ? _mailAddress : ""; }
        }
        public PricePlan PricePlan { get; }
        public EnableSetting EnableSetting { get; }
    }
}
