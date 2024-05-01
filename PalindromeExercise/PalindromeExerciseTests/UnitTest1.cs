using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("kayak", true)]
        [InlineData("cat", false)]
        [InlineData("blue", false)]
        [InlineData("bob", true)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            WordSmith wordsmith = new WordSmith();

            bool actual = wordsmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
