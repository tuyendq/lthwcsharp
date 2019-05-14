using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            CustomerTest customer = new CustomerTest();
            customer.FirstName = "Tuyen";
            customer.LastName = "Dang";
            string expected = "Tuyen, Dang";
            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
