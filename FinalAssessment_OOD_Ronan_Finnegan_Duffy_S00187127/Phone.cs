using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssessment_OOD_Ronan_Finnegan_Duffy_S00187127
{
    public class Phone
    {
        // Properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasePrice(decimal increaseAmount)
        {
            decimal percentageIncrease = Price * increaseAmount / 100;
            Price = Price + percentageIncrease;
        }
    }
    public class PhoneData : DbContext
    {
        public PhoneData() : base("PhoneData") { }

        public DbSet<Phone> phones { get; set; }
    }
}
