using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalAssessment_OOD_Ronan_Finnegan_Duffy_S00187127;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of PhoneData
            PhoneData db = new PhoneData();

            // Code first database using this instance
            using (db)
            {
                // Create two phone objects as per question
                Phone phone1 = new Phone() { Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg" };
                Phone phone2 = new Phone() { Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iphone11.jpg" };

                // Add the phohe objects to the database
                db.phones.Add(phone1);
                db.phones.Add(phone2);

                Console.WriteLine("Writing the phones to the database");

                // Write the questions to the database
                db.SaveChanges();

                
            }
        }
    }
}
