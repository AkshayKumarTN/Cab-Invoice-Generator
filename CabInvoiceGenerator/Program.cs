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
        }
    }
}
