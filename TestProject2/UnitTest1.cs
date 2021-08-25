using IsItALeapYear;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]


        public void Year_2001_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();


            // Act
             var expected = false;

            var actual = p.IsItALeapYear(2001);

            // Assert

              Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Year_1996_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYear(1996);

            // Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Year_1900_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYear(1900);

            // Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Year_2000_Is_not_a_leap_year()

        {

            // Arrange

            var p = new Program();

            var expected = false;

            // Act

            var actual = p.IsItALeapYear(2000);

            // Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
