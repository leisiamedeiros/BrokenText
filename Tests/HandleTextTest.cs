using BrokenText;
using Xunit;

namespace Tests
{
    public class HandleTextTest
    {
        const string PARAGRAPH = @"In 1991, while studying computer science at University of Helsinki, Linus Torvalds began a project that later became the Linux kernel. He wrote the program specifically for the hardware he was using and independent of an operating system because he wanted to use the functions of his new PC with an 80386 processor. Development was done on MINIX using the GNU C Compiler.";

        [Theory]
        [InlineData(40)]
        [InlineData(30)]
        [InlineData(20)]
        public void HandleTextBrokeLineTest(int maxLength)
        {
            // act
            var result = HandleText.BrokeTextInLines(PARAGRAPH, maxLength);

            // assert
            foreach (var item in result)
            {
                Assert.True(item.Length <= maxLength, $"The word {item} has the lenght of ${item.Length}");
            }
        }
    }
}
