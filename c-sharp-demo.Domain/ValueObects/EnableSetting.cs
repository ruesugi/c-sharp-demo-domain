using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo.Domain.ValueObects
{
    public sealed class EnableSetting : ValueObject<EnableSetting>
    {
        public static readonly EnableSetting Enable = new EnableSetting(0);
        public static readonly EnableSetting Disable = new EnableSetting(1);

        public EnableSetting(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public string DisplayValue
        {
            get
            {
                if (this == Enable)
                {
                    return "有効";
                }
                if (this == Disable)
                {
                    return "無効";
                }
                return "";
            }
        }

        public static IList<EnableSetting> ToList()
        {
            return new List<EnableSetting>
            {
                Enable,
                Disable,
            };
        }

        protected override bool EqualsCore(EnableSetting other)
        {
            return Value == other.Value;
        }
    }
}
