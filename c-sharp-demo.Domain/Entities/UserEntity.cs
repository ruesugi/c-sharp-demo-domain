﻿using c_sharp_demo.Domain.ValueObects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            MailAddress = mailAddress;
            PricePlan = new PricePlan(pricePlan);
            EnableSetting = new EnableSetting(enableSetting);
        }

        public int Id { get; }
        public bool IsSending { get; }
        public string MailAddress { get; }
        public PricePlan PricePlan { get; }
        public EnableSetting EnableSetting { get; }
    }
}
