using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Creator.xaml
    /// </summary>
    public partial class Creator : Page
    {
        
        public Creator(double physDam)
        {
            InitializeComponent();
        }
        private void slotWeapon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("/iamge/image (4).png", UriKind.Relative));
            slot4.Child = img;
            slotWeapon.Child = null;
        }

        private void slot4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("/iamge/image (4).png", UriKind.Relative));
            slotWeapon.Child = img;
            slot4.Child = null;
        }

        private void CreatorBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
