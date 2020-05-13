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
            var query = (from Phone in db.phones
                         select Phone).ToList();

            foreach(var phone in query)
            {
                phoneList.Add(phone);
            }

            listBox.ItemsSource = phoneList;
        }
    }
}
