using NUnit.Framework;
using AulaTestes;

namespace AulaTestes.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ClasseQueFazAlgo Cfa = new ClasseQueFazAlgo();


            Assert.AreEqual(true, Cfa.FazAlgo());
            Assert.Pass();
        }
    }
}