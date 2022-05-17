using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OODMay2022_S00212883
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //I am very annoyed at this
        public List<RentalProperty> property = new List<RentalProperty>();

        public MainWindow()
        {
            InitializeComponent();
            #region
            RentalProperty p1 = new RentalProperty()
            {
                Price = 400m,
                TypeOfRental = RentalType.Flat,
                Description = "A modern 1 bedroom apartment located close to the campus." +
      "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
      "a small kitchen and a lounge/dining room",
                Location = "Town Centre"
            };

            RentalProperty p2 = new RentalProperty()
            {
                Price = 400m,
                TypeOfRental = RentalType.House,
                Description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                "The house has 4 large double bedrooms with ample space for a desk, " +
                "a large kitchen with all mod cons.  " +
                "There is also a dining room and a large sitting room",
                Location = "Ballinode"
            };

            RentalProperty p3 = new RentalProperty()
            {
                Price = 400m,
                TypeOfRental = RentalType.Share,
                Description = "1 bedroom available to share in a 3 bedroom house located in the " +
                "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                "IT Sligo with regular buses to and from the campus",
                Location = "Strandhill"
            };

            property.Add(p1);
            property.Add(p2);
            property.Add(p3);
            #endregion
            InsertPropertiesintoListBox();
        }

        //Insert Properties into the listbox
        public void InsertPropertiesintoListBox()
        {
            //i cant test it but this qould be the right linq for this
            //var query = from prop in DB.PropertyTBL
            //          OrderByDescending prop.Price
            //          select prop
            property.Sort();
            PropertyListbox.ItemsSource = property;
            
        }

        //Enters property info into the label
        private void PropertyListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RentalProperty selectedprop = PropertyListbox.SelectedItem as RentalProperty;

            if(selectedprop != null)
            {
                DescriptionLabel.Content = selectedprop.Description;
            }
        }

        private void AddListingbtn_Click(object sender, RoutedEventArgs e)
        {
            Window1 subWindow = new Window1();
            subWindow.Show();
        }
    }
}
