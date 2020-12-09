﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Model
{
    public class AccountTransfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TranferAmount { get; set; }
    }
}
