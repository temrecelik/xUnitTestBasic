﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest.App
{
    public class CalculatorService : ICalculatorService

    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}

