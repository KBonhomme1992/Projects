using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            DateTime NextInvoiceDate;
            DateTime NextPaymentDate;

            Compte Compte1 = new Compte();

            Compte1.name = "Hydro";
            Compte1.Price = 192.55;
            Compte1.ReceiveInvoiceDate = DateTime.Now;
            Compte1.HasToPayDate = DateTime.Now;

            NextInvoiceDate = Compte1.ReceiveInvoiceDate.AddMonths(1);
            NextPaymentDate = Compte1.HasToPayDate.AddMonths(1);
            
            /*
            MessageBox.Show(Compte1.name + " Price = " + Compte1.Price);
            MessageBox.Show("Invoice Received Date : " + Compte1.ReceiveInvoiceDate);
            MessageBox.Show("Next Invoice Date : " + NextInvoiceDate);
            MessageBox.Show("Payment Date : " + Compte1.HasToPayDate);
            MessageBox.Show("Next Payment Date :" + NextPaymentDate);
            */
            

        }
    }

}
