namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public sealed class ReservationUnitTest
    {
        [TestMethod]
        public void CanBeCancelledBy_CancelledByAdmin_ReturnTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation(user);

            User admin = new User();
            admin.IsAdmin = true;

            bool result = reservation.CanBeCancelledBy(admin);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CanBeCancelledBy_CancelledByMadeBy_ReturnTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation(user);

            bool result = reservation.CanBeCancelledBy(user);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void CanBeCancelledBy_CancelledByNotAdminNotMadeBy_ReturnFalse()
        {
            User userBy = new User();
            Reservation reservation = new Reservation(userBy);
            User userRandom = new User();

            bool result = reservation.CanBeCancelledBy(userRandom);

            Assert.AreEqual(result, false);
        }
    }
}
