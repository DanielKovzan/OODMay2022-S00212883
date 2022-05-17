using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODMay2022_S00212883
{
    public enum Types
    {
        House,
        Flat,
        Share
    }
    public class RentalProperty
    {
        //Properties
        public int ID { get; set; }
        public Types RentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //Constructors
        public RentalProperty()
        {

        }

        //Methods
        public void IncreaseRent(decimal Percentage)
        {
            Price += Price * Percentage;
        }

    }//End of RentalProperty CLass

    public class RentalData : DbContext
    {
        public RentalData(): base("RentalDatabase") { }

        public DbSet<RentalProperty> Property { get; set;}
    }
}
