using IsItALeapYear;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2001,false)]
        [DataRow(1996, true)]
        [DataRow(1900, false)]
        [DataRow(2000, true)]

        public void Year_2001_Is_not_a_leap_year(int yr,bool ex)

        {

            // Arrange

            var p = new Program();


            // Act

            var actual = p.IsItALeapYear(yr);

            // Assert

            Assert.AreEqual(ex, actual);

        }
    }
}
