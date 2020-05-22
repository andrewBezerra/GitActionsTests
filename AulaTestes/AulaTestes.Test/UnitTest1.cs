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
        public void TesteCerto()
        {
            ClasseQueFazAlgo Cfa = new ClasseQueFazAlgo();


            Assert.AreEqual(true, Cfa.FazAlgo());
            Assert.Pass();
        }
        [Test]
        public void TesteErrado()
        {
            ClasseQueFazAlgo Cfa = new ClasseQueFazAlgo();


            Assert.AreEqual(false, Cfa.FazAlgo());
            Assert.Pass();
        }
    }
}