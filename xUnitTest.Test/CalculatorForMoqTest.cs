using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest.App;

namespace xUnitTest.Test
{
    public class CalculatorForMoqTest
    {
        private readonly Mock<ICalculatorService> _mock;
        public CalculatorForMoq CalculatorForMoq { get; set; }

        public CalculatorForMoqTest()
        {
            _mock = new Mock<ICalculatorService>();
            CalculatorForMoq = new CalculatorForMoq(_mock.Object);
        }



        [Theory]
        [InlineData(2,5,7)]
        [InlineData(3,5,8)]

        public void add_SimpleValues_ReturnTotalValue(int a , int b , int ExpectedTotal)
        {
             
             _mock.Setup(x => x.add(a,b)).Returns(ExpectedTotal);

            int actualTotal = CalculatorForMoq.add(a,b);

            Assert.Equal(ExpectedTotal, actualTotal);

        }
    }
}
