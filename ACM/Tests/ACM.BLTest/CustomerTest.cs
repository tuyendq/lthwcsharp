using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
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
