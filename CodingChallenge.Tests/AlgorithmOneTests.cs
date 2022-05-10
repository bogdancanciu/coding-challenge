using NUnit.Framework;

namespace CodingChallenge.Tests
{
    public class AlgorithmOneTests
    {
        [Test]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11, 6, 13, 113, 119, 16 }, 22)]
        [TestCase(new int[] { 0, 4, 6, 8, 7, 13, 22, 19, 65, 73, 19 }, 40)]
        [TestCase(new int[] { 13, 15, 29, 8, 9, 39, 101, 3, 333, 333 }, 8)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 30)]
        [TestCase(new int[] { 19, 29, 39, 49, 59, 12, 13, 14, 2, 3, 3, 3, 3, 2 }, 30)]
        [TestCase(new int[] { 2, 2, 2, 2, 19, 20 }, 28)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 2, 4, 4, 2 }, 12)]
        public void AlgorithmOne_Test(int[] arr, int result)
        {
            AlgorithmOne algo = new AlgorithmOne(arr);
            Assert.AreEqual(algo.Solve(), result);
        }
    }
}