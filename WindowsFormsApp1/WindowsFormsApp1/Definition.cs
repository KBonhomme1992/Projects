using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;



namespace WindowsFormsApp1
{
    public partial class Definition : Form
    {
        public Definition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cpt;
            double price;


            cpt = TxtName.Text;

            if (TxtPrice != null) 
            {
                price = Convert.ToDouble(TxtPrice.Text);
            }
            else price = 0.00;
            


            MessageBox.Show(cpt);
            MessageBox.Show(Convert.ToString(price));

            SaveData(cpt, Convert.ToDouble(price));

        }


        void SaveData(string cptname, Double prc)
        {
            // Create a hashtable of values that will eventually be serialized.
            Hashtable Data = new Hashtable();
            Data.Add("Jeff", "123 Main Street, Redmond, WA 98052");
            Data.Add("Fred", "987 Pine Road, Phila., PA 19116");
            Data.Add("Mary", "PO Box 112233, Palo Alto, CA 94301");

            // To serialize the hashtable and its key/value pairs,   
            // you must first open a stream for writing.  
            // In this case, use a file stream.
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, Data);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


    }
}
