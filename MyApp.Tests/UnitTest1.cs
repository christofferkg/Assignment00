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
    }
}
