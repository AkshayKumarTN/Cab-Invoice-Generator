using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Cab Invoice Generator");
            InvoiceGenerator invoice = new InvoiceGenerator();
            Console.WriteLine("\n Total fare for the journey : "+invoice.CalculateFare(2.0, 5));
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(3.0, 2),
                new Ride(4.0, 4),
                new Ride(5.0, 3)
            };
            InvoiceSummary invoiceSummary = invoice.CalculateFare(rides);
            Console.WriteLine("\n Total fare for Multiple Rides : " + invoiceSummary.totalFare);
            Console.WriteLine(" Average Fare for Multiple Rides : " + invoiceSummary.averageFare);


        }
    }
}
