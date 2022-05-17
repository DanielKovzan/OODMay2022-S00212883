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
using System.Windows.Shapes;

namespace OODMay2022_S00212883
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            if(combo.SelectedItem != null && locationbx.Text != null && pricebx.Text != null && descriptionbx.Text != null &&)
            {
                if (combo.SelectedItem == "House")
                {

                }
                else if (combo.SelectedItem == "Flat")
                    {

                    }
                else if (combo.SelectedItem == "Share")
                {

                }

            }
        }
    }
}
