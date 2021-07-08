using c_sharp_demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo.Domain.Entities
{
    public sealed class EnableEntity
    {
        public EnableEntity(int enableId, EnableSetting enableSetting)
        {
            EnableId = enableId;
            EnableSetting = enableSetting;
        }

        public int EnableId { get; }
        public EnableSetting EnableSetting { get; }
    }
}
