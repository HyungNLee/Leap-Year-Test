using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.TestTools
{
  [TestClass]
  public class LeapYearTest
  {
    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }

    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByOneHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }

    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFourHundred_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
