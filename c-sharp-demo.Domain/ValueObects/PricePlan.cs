namespace c_sharp_demo.Domain.ValueObects
{
    public sealed class PricePlan : ValueObject<PricePlan>
    {
        public PricePlan(int value)
        {
            Value = value;
        }
        public int Value { get; }

        protected override bool EqualsCore(PricePlan other)
        {
            return Value == other.Value;
        }
    }
}
