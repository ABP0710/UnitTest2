using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest2
{
    [Collection("UnitTestCollection")]

    public class AtmTest
    {
        //First we if the pin is valid, it's just written in plain text for test purpurses 
        [Theory] //makes it possible to use mulible data sets with the [InlineData]
        [InlineData(1234, 1234)]
        [InlineData(9876, 9876)]
        public void PinNumbers_ShouldValidate(int arrangePinNumber, int actPinNumber)
        {
            // Arrange

            // Act, gets it data from the [InlineData] parmeters
            bool pinCheck = CheckPinNumbers(arrangePinNumber, actPinNumber);

            // Assert
            Assert.True(pinCheck);
        }

        [Theory]
        [InlineData(1234, 5678)]
        [InlineData(123.345, 567.789)]
        public void WithdrawAmount_ShouldValidate(decimal wihtdrawAmount, decimal amountInAccount)
        {
            // Arrange

            // Act
            bool result = SubtractWihtdrawAndCheckAmount(wihtdrawAmount, amountInAccount);

            // Assert
            Assert.True(result); // Change to Assert.False if you expect the result to be less than 0
        }


        private bool CheckPinNumbers(int arrangePinNumber, int actPinNumber)
        {
            return arrangePinNumber == actPinNumber;
        }

        private bool SubtractWihtdrawAndCheckAmount(decimal wihtdraw, decimal amountInAccount)
        {
            return (wihtdraw - amountInAccount) >= 0;
        }
    }
}
