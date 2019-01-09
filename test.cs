using NUnit.Framework;
using System;
namespace Application
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void TestCase()
        {
          {
            Assert.AreEqual(1, 1);

          }
        }
    }
}
