﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSATSAPI.Models.ComplexTypes
{
    [Keyless]
    public class sproc_UpdateCurrencyExchangeRate_Result
    {
        public int result { get; set; }
    }
}