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
            string expected = "Dang, Tuyen";
            //-- Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmptyTest()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Dang"
            };
            string expected = "Dang";

            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmptyTest()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Tuyen"
            };
            string expected = "Tuyen";

            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }        
    }
}
