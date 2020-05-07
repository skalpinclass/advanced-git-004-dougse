using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace demo.test
{
    [TestClass]
    public class UnitTest1
    {
        private Random random;

        [TestInitialize]
        public void Initialize()
        {
            random = new Random();
        }

        [TestMethod]
        public void TestMethod1()
        {
            for(var i = 0; i < 1000; i++)
            {
                var number = random.Next(0,1);
<<<<<<< HEAD
                Assert.AreEqual(0, number);
=======
                if(number == 1)
                {
                    return;
                }
>>>>>>> 82b350c... assert if a 1 is not found
            }

            Assert.Fail();
        }
    }
}
