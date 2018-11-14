 using Clock;
 using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clock.Test
{
    [TestClass]
    public class ClockAngleTest
    {
        [TestMethod]
        public void ClockHandAngles()
        {
            Assert.AreEqual(132.5, ClockAngle.Angles(9, 25));
        }
    }
}


