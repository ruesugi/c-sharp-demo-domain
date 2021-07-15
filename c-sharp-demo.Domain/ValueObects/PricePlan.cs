namespace c_sharp_demo.Domain.ValueObects
{
    public sealed class PricePlan : ValueObject<PricePlan>
    {
        public static readonly PricePlan Free = new PricePlan(0);
        public static readonly PricePlan Business = new PricePlan(1);
        public PricePlan(int value)
        {
            Value = value;
        }
        public int Value { get; }
        public string DisplayValue 
        {
            get 
            {
                if (this == Free) return "無料";
                if (this == Business) return "ビジネス";
                return "-";
            }
        }

        public static PricePlan GetPricePlan(bool free, bool business)
        {
            if (free && !business) return Free;
            else if (!free && business) return Business;

            return new PricePlan(-1);
        }

        protected override bool EqualsCore(PricePlan other)
        {
            return Value == other.Value;
        }
    }
}
