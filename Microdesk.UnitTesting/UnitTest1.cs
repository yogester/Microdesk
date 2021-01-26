using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microdesk.DataAccess;
using Moq;
using Microdesk.BusinessLogic;
using Microdesk.Controllers;

namespace Microdesk.UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student _s = new Student();
            _s.Name = "The value read from the database is: Yogendra"; 
            var mock = new Mock<IStudentRepository>();
            mock.Setup(p => p.GetStudent(1)).Returns(_s);
            HomeController home = new HomeController(mock.Object);
            string result = home.StudentName();
            Assert.AreEqual("The value read from the database is: Yogendra", result);

        }
    }
}
