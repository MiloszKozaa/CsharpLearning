using Game;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Game.Tests
{
    public class RandomNumber
    {
        [Fact]
        public void TestA()
        {
            var mockedRandomNumber = new Mock<IRandomNumber>();

            mockedRandomNumber.Setup(m => m.GetRandomNumber(It.IsAny<int>())).Returns(0);

            var unitToTest = BuildRandomChoice(mockedRandomNumber.Object);
            var result = unitToTest.GetRandomChoice();
        }
        private IRandomChoice BuildRandomChoice(IRandomNumber randomNumber)
        {
            return new RandomChoice(randomNumber);
        }
    }
}
