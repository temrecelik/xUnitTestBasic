using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitTest.App;

namespace xUnitTest.Test
{
    public class CalculatorTest
    {


        /*
         When writing a test about a class, we need to access the functions in that class for each test.For this reason, 
         we need to create one object from the class to be tested. We should create this object in the test classin so as 
         not to create an object repeatedly in each test function.
        */
        public Calculator calculator { get; set; }    
       
        
        public CalculatorTest(Calculator calculator)
        {
            this.calculator = calculator;
        }


        [Fact]
        public void add_SimpleValues_returnTotalValues()
        {

        
        //Arrange 
        int a = 5;
        int b = 40;
        

        //Act
         var total = calculator.add(a,b);

         //Assert
         Assert.Equal<int>(45,total);


         }


        //Writing a Test Method With  Parameters

        [Theory] //if there are paremeters , use Theory instead of [Fact]

        [InlineData(2,5,7)] //You can create fake data for parameter with [InlineData] .You can do this more than once !
        [InlineData(1, 9, 10)]

        public void add_SimpleValues_returnTotalValue(int a,int b, int Expectedtotal)
        {
           
            var ActualTotal = calculator.add(a,b);

            Assert.Equal(Expectedtotal,ActualTotal);
        }
    }
}
