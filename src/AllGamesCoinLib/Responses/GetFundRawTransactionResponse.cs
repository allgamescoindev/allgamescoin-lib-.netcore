﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AllGamesCoinLib.Responses
{
    public class GetFundRawTransactionResponse
    {
        public string Hex { get; set; }
        public decimal Fee { get; set; }
        public int ChangePos { get; set; }
    }
}
