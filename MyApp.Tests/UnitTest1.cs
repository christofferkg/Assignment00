using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void mainPrintsHelloWorld()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello, World!", output); 
        }

        [Fact]
        public void IsLeapYearIsFalse() {
            int year = 2010;
            var output = Program.IsLeapYear(year);
            Assert.False(output);
        }

        [Fact]
        public void DivisibleByFourIsLeapYear() {
            int year = 2012;
            var output = Program.IsLeapYear(year);
            Assert.True(output);
        }

        [Fact]
        public void DivisibleBy400IsLeapYear() {
            int year = 1600;
            var output = Program.IsLeapYear(year);
            Assert.True(output);
        }

        [Fact]
        public void DivisibleBy100IsNotLeapYear() {
            int year = 1900;
            var output = Program.IsLeapYear(year);
            Assert.False(output);
        }
    }
}
