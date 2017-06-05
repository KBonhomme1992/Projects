using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Compte
    {
        // Field
        public string name;
        public Double Price;
        public DateTime HasToPayDate;
        public DateTime ReceiveInvoiceDate;

        // Constructor that takes no arguments.
        public Compte()
        {
            name = "unknown";
            Price = 0.00;
            HasToPayDate = DateTime.Now;
            ReceiveInvoiceDate = DateTime.Now;

        }

        // Constructor that takes one argument.
        public Compte(string nm, Double Prc, DateTime PayDate, DateTime InvoiceDate)
        {
            name = nm;
            Price = Prc;
            HasToPayDate = PayDate;
            ReceiveInvoiceDate = InvoiceDate;
        }

        // Method
        public void ChangeName(string newName)
        {
            name = newName;
        }

        public void SetPrice(Double Prc)
        {
            Price = Prc;
        }

        public void SetPayDate(DateTime date)
        {
            HasToPayDate = date;
        }


        public void SetInvoiceDate(DateTime date)
        {
            ReceiveInvoiceDate = date;
        }

    }
}
