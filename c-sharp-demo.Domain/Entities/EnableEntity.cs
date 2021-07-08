using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_demo.Domain.Entities
{
    public sealed class EnableEntity
    {
        public EnableEntity(int enableId, string enableSetting)
        {
            EnableId = enableId;
            EnableSetting = enableSetting;
        }

        public int EnableId { get; }
        public string EnableSetting { get; }
    }
}
