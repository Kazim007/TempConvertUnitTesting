using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempConvert;


namespace ConversionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestF2C()
        {
            double f = 32;
            double c = 0;
            double  rvalue = TempConvert.Convert.f2c(f);
            Assert.AreEqual(c, rvalue); 
        }
    }
}