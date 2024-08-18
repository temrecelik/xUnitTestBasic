using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest.App
{
    public class CalculatorForMoq 
    {

        private readonly ICalculatorService _calculatorService;

        public CalculatorForMoq(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int add(int a, int b)
        {
            var total = _calculatorService.add(a, b);
            return total;
        }
      
    }
}
