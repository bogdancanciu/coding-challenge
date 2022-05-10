using NUnit.Framework;

namespace CodingChallenge.Tests
{
    public class AlgorithmTwoTests
    {
        [Test]
        [TestCase(new char[] { 'a', 'b', 'c', 'd', 'f' }, 'e')]
        [TestCase(new char[] { 'O', 'Q', 'R', 'S' }, 'P')]
        [TestCase(new char[] { 'x', 'z' }, 'y')]
        [TestCase(new char[] { 'h', 'i', 'j', 'l', 'm', 'n', 'o', 'p', 'q' }, 'k')]
        [TestCase(new char[] { 'a', 'c' }, 'b')]
        [TestCase(new char[] { 'D', 'E', 'F', 'H', 'I' }, 'G')]
        [TestCase(new char[] { 'M', 'O' }, 'N')]
        [TestCase(new char[] { 'g', 'h', 'i', 'k', 'l' }, 'j')]
        [TestCase(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's' }, 'q')]
        [TestCase(new char[] { 'A', 'B', 'C', 'D', 'E', 'G' }, 'F')]
        public void AlgorithmTwo_Test(char[] arr, int result)
        {
            AlgorithmTwo algo = new AlgorithmTwo(arr);
            Assert.AreEqual(algo.Solve(), result);
        }
    }
}