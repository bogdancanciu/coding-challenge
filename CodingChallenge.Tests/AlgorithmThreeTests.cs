using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallenge.Tests
{
    public class AlgorithmThreeTests
    {
        [Test]
        [TestCaseSource("TestCaseSourceData")]
        public void AlgorithmThree_Test(Stack<char> s1, Stack<char> s2, string result)
        {
            AlgorithmThree algo = new AlgorithmThree(s1, s2);
            Assert.AreEqual(algo.Solve(), result);
        }
        public static IEnumerable<TestCaseData> TestCaseSourceData()
        {
            yield return new TestCaseData(new Stack<char>(new[] { 'A', 'C', 'A' }), new Stack<char>(new[] { 'F', 'C', 'B' }), "ABCACF");
            yield return new TestCaseData(new Stack<char>(new[] { 'A' }), new Stack<char>(new[] { 'F', 'C', 'B' }), "ABCF");
            yield return new TestCaseData(new Stack<char>(new[] { 'D', 'B', 'I' }), new Stack<char>(new[] { 'A', 'F', 'K', 'C', 'H', 'A' }), "AHCIBDKFA");
            yield return new TestCaseData(new Stack<char>(new[] { 'C', 'D', 'E' }), new Stack<char>(new[] { 'C', 'D', 'E' }), "EDCEDC");
            yield return new TestCaseData(new Stack<char>(new[] { 'B', 'B', 'A' }), new Stack<char>(new[] { 'X', 'Y', 'Z', 'A' }), "AABBZYX");
            yield return new TestCaseData(new Stack<char>(new[] { 'G' }), new Stack<char>(new[] { 'M', 'I', 'D', 'A', 'C' }), "CADGIM");
            yield return new TestCaseData(new Stack<char>(new[] { 'M' }), new Stack<char>(new[] { 'M' }), "MM");
            yield return new TestCaseData(new Stack<char>(new[] { 'X', 'X' }), new Stack<char>(new[] { 'A', 'C', 'D', 'I', 'J' }), "JIDCAXX");
            yield return new TestCaseData(new Stack<char>(new[] { 'A', 'A', 'X' }), new Stack<char>(new[] { 'B', 'E', 'F', 'D', 'O' }), "ODFEBXAA");
            yield return new TestCaseData(new Stack<char>(new[] { 'V', 'C', 'D', 'M', 'I' }), new Stack<char>(new[] { 'D', 'M', 'M', 'W', 'G', 'A' }), "AGIMDCVWMMD");
        }
    }
}