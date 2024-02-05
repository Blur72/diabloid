using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Page
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnSingle_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Characters());
        }
    }
}
