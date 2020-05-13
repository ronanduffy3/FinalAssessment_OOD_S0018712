using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace FinalAssessment_OOD_Ronan_Finnegan_Duffy_S00187127
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        List<Phone> phoneList = new List<Phone>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            // Query to read the phones from the database
            var query = (from Phone in db.phones
                         select Phone).ToList();

            // Run a loop to add all the phones found in the query
            foreach(var phone in query)
            {
                phoneList.Add(phone);
            }

            // Set that to the item source
            listBox.ItemsSource = phoneList;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Cast the selected item to a phone object
            Phone selectedItem = listBox.SelectedItem as Phone;

            // Get the phone_image location from the database
            string img = selectedItem.Phone_Image.ToString();

            var imgN = new BitmapImage();

            imgN.BeginInit();
            imgN.UriSource = new Uri(selectedItem.Phone_Image.ToString(), UriKind.Relative);
            imgN.EndInit();

            imgPhone.Source = imgN;

            // Set the text to the cost of the phone
            tblkPrice.Text = selectedItem.Price.ToString("C");

        }
    }
}
