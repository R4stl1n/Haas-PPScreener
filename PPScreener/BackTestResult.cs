﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPScreener
{
    public class BackTestResult
    {
        public DateTime Date { get; set; }
        public string Pair { get; set; }
        public decimal ROI { get; set; }
        public bool AboveThreshold { get; set; }

    }
}
