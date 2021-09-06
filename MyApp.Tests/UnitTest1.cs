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

        [Fact]
        public void IsLeapYear_OutputsYay() {
            var reader = new StringReader("2000");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            string output = writer.ToString();
            output = output.Split("\n")[1];

            Assert.Equal("yay", output);
        }

        [Fact]
        public void IsLeapYear_OutputsNay() {
            var reader = new StringReader("1973");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            string output = writer.ToString();
            output = output.Split("\n")[1];

            Assert.Equal("nay", output);
        }
    }
}
