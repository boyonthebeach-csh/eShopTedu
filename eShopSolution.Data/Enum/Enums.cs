﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Enum
{
    public class Enums
    {
        public enum Status
        {
            InActive,
            Active
        }
        public enum TransactionStatus
        {
            Success,
            Failed
        }

        public enum OrderStatus
        {
            InProgress,
            Confirmed,
            Shipping,
            Success,
            Canceled
        }
    }
}
