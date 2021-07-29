using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CalculateFareMethodReturnsTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 20;
            int time = 45;
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 245;
            Assert.AreEqual(expectedFare, actualFare);
        }
        [TestMethod]
        public void CalculateFareReturnsMinimumFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.2;
            int time = 2;
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 5;
            Assert.AreEqual(expectedFare, actualFare);
        }
        [TestMethod]
        public void CalculateFareMethodReturnsTotalFareMultipleRides()
        {
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(3.0, 2),
                new Ride(4.0, 4),
                new Ride(5.0, 3)
            };
            double expected = 162;
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            double actual = summary.totalFare;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvoiceSummaryReturnsTotalNumberOfRides()
        {
            // Returns Total Number Of Rides........
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(3.0, 2),
                new Ride(4.0, 4),
                new Ride(5.0, 3)
            };
            int expected = 5;
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            int actual = summary.numberOfRides;
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void InvoiceSummaryReturnsTotalNumberOfRidesTotalFare()
        {
            // Returns Total Number Of Rides Total Fare........
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(3.0, 2),
                new Ride(4.0, 4),
                new Ride(5.0, 3)
            };
            double expected = 162;
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            double actual = summary.totalFare;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InvoiceSummaryReturnsTotalNumberOfRidesAverageFare()
        {
            // Returns Total Number Of Rides Average Fare........
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(3.0, 2),
                new Ride(4.0, 4),
                new Ride(5.0, 3)
            };
            double expected = 32.4;
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            double actual = summary.averageFare;
            Assert.AreEqual(expected, actual);
        }
    }
}
