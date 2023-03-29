using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using positiveNegative;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1_trg
    {
        [TestMethod]
        public void TestMethod1_NumberCheck()
        {
            trg_class obj = new trg_class();
            string result = obj.NumberCheck("0"); // test data should be written here
            string DU = "zero"; // DU should be estimated by the test (hard task)
            Assert.AreEqual(DU, result);

        }
    }

    [TestClass]
    public class UnitTest2_digitclass
    {
        [TestMethod]
        public void TestMethod1_prime() //the first test of the prime method
        {
            Digit_class obj = new Digit_class();
            int[] test_data = new int[3] { 6,28,496 };
            int correct_output = 1;
            for (int i = 0; i < test_data.Length; i++)
            {
                int result = obj.prime(test_data[i]);
                Assert.AreEqual(correct_output, result);

            }

          
        }
    }
}
