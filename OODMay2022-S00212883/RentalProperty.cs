using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODMay2022_S00212883
{
    public enum RentalType
    {
        House,
        Flat,
        Share
    }
    public class RentalProperty : IComparable
    {
        //Properties
        public int ID { get; set; }
        public RentalType TypeOfRental { get; set; }
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

        int IComparable.CompareTo(object input)
        {
            RentalProperty toCompare = (RentalProperty)input;
            return this.Price.CompareTo(toCompare.Price);
        }

    }//End of RentalProperty CLass

    public class RentalData : DbContext
    {
        public RentalData(): base("RentalDatabase") { }

        public DbSet<RentalProperty> Property { get; set;}
    }
}
