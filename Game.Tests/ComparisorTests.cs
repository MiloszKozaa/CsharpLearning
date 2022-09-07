using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Game.Tests
{
    public class ComparisorTests
    {
        [Fact]
        public void TestA()
        {
            var unitToTest = BuildComparisor();

            var result = unitToTest.FindWinner("rock", "rock");

            Assert.Equal(Winner.Noone, result);
        }

        [Fact]
        public void TestB()
        {
            var unitToTest = BuildComparisor();

            Assert.Throws<Exception>(() => unitToTest.FindWinner("banana", "apple"));
        }

        private IComparisor BuildComparisor()
        {
            return new Comparisor();
        }
    }
}