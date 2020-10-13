using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expected = true;
            string firstName = "Nivas";
            string lastName = "Grandhi";
            string emailID = "ggj.nivas@ggmail.com";
            string mobileNum = "91 8790988099";
            string password = "Asdfg@1sbj";
            UserRegPattern pattern = new UserRegPattern();
            Assert.AreEqual(expected, pattern.ValidateFirstName(firstName));
            Assert.AreEqual(expected, pattern.ValidateLastName(lastName));
            Assert.AreEqual(expected, pattern.ValidateEmail(emailID));
            Assert.AreEqual(expected, pattern.ValidateMobile(mobileNum));
            Assert.AreEqual(expected, pattern.ValidatePassword(password));
        }
        
    }
}
