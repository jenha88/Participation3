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

namespace WPF_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Addbtb_Click(object sender, RoutedEventArgs e)
        {

          
            string name, manufacturer, image, price;

            double p = 0;
            name = txtN.Text;
            manufacturer = txtM.Text;
            image = Imagetxt.Text;
            price = txtP.Text;

            // validating if the user's input 
            if (string.IsNullOrEmpty(name)==true)
            {
                MessageBox.Show("invalid name" );
            }
            if (string.IsNullOrEmpty(manufacturer)==true)
            {
                MessageBox.Show("imvalid manufacturer");
            }
            if (string.IsNullOrEmpty(image)==true)
            {
                MessageBox.Show("invalid image");
            }
            if (double.TryParse(price, out p)==false) 
            {
                MessageBox.Show("invalid price");
            }
            // constructor 
            Toy ListToy = new Toy()
            {
                Manufacturer = manufacturer, 
                Name= name, 
                image=image,
                price=p, 
            };
            TT.Items.Add(ListToy);//adding to the listbox 
            }

        //what is in the listbox 
        private void ListToy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)TT.SelectedItem;
            var uri = new Uri(selectedToy.image);
            var img = new BitmapImage(uri);
            imgbox.Source = img;
            MessageBox.Show($"{selectedToy.GetAisle()}");
        }
    }

}
