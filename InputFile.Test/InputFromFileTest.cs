using System;
using InputFile;
using Xunit;

namespace InputFile.Test
{
    public class InputFromFileTest
    {
        private readonly InputFromFile _inputFromFile;

        public InputFromFileTest()
        {
            _inputFromFile = new InputFromFile();
        }
        [Theory]
        [InlineData("C:\\Users\\1111\\source\\repos\\quad-testing\\2.txt")]
        [InlineData("C:\\Users\\1111\\source\\repos\\quad-testing\\1.txt")]
        [InlineData("C:\\Users\\1111\\source\\repos\\quad-testing\\3.txt")]
        public void IsInput_ValueNotNull_ReturnFalse(string uri)
        {
            var result = _inputFromFile.FromFile(uri);
            Assert.True(result, $"{uri} param A should be bot null");

        }
    }
}
