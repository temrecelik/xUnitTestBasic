using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest.Test
{
    public class AssertMethodsNotes
    {

        [Fact]
        public void AssertMethods()
        {
            //Asserts

            /*1-)Contains Method:In the Contains method, if the first parameter contains a part of the second parameter, the test 
             * succeeds*/

            //Assert.Contains("Car", "Blue Car");


            /*2-)DoesNotContains Method:Contains Method:In the Contains method, if the first parameter dos not contains a part of the 
               second parameter, the test  succeeds*/

            //Assert.DoesNotContain("Car", "Blue Bus");


            /*3-) True Method: if condition is true ,test succeeds
                  False Method: if condtion is false,test succeeds*/

            //Assert.True(6 > 2);
            //Assert.False(10 == 20);


            /*4-)Matches Method: if the given regex code matches the entered value, the test will be successful.
                 the opposite is the doesnotmatch method.*/

            // var regEx = "^dog"; // it means string should start with dog word;
            //Assert.Matches(regEx, "dog is a animal");



            /*5-)StartsWith: if the value in the second parameter starts with the value in the first parameter, the test is successful.*/

            //Assert.StartsWith("Hello", "Hello how is your day ?");



            /*6-)Endwith:if the value in the second parameter ends with the value in the first parameter, the test is successful.*/

            //Assert.EndsWith("You are the one!", "one!");


            /*7-)Empty Method: if there is no data in the variables of the enumerable type, the test is successful*/
            //Assert.Empty(new List<string>());


            /*8-)NotEmpty Method: if there is  data in the variables of the enumerable type, the test is successful*/
            //Assert.NotEmpty(new List<string>() { "Car" ,"Blues"} );


            /*9-)InRange Method:if the value entered is a value between the given values, the test is successful.*/
            //int EnteredValue = 20;
            //Assert.InRange(EnteredValue, 10, 30);


            /*10-)NotInRange Method:if the value entered is not a value between the given values, the test is successful.*/

            //int EnteredValue = 20;
            //Assert.NotInRange(EnteredValue, 50, 100);


            /*11-)Single Method :if there is only one data in a variable of the enumerable type,the test is successful.*/
            //Assert.Single(new List<string>() { "Car"});


            /*12-) IsType Method :if the type of paremeter entered and the type entered are the same, the test is successful.
             The type must be specified as generic*/
            //int number = 10;
            //Assert.IsType<int> (number);





        }
    }
}
