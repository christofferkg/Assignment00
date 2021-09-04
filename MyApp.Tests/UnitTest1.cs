using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_False() {
            int year = 2010;
            var output = Program.IsLeapYear(year);
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_DivisibleByFourTrue() {
            int year = 2012;
            var output = Program.IsLeapYear(year);
            Assert.True(output);
        }

        [Fact]
        public void IsLeapYear_DivisibleBy400IsTrue() {
            int year = 1600;
            var output = Program.IsLeapYear(year);
            Assert.True(output);
        }

        [Fact]
        public void IsLeapYear_DivisibleBy100IsFalse() {
            int year = 1900;
            var output = Program.IsLeapYear(year);
            Assert.False(output);
        }
    }
}
