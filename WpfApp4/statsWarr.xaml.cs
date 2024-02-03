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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для statsWarr.xaml
    /// </summary>
    public partial class statsWarr : Page
    {
        Warior warior = new Warior(1, 30, 10, 15, 25, 2, 2, (int) (str * 0.2), 1 , 2, 2, 2, 2);
        private static double str;

        public statsWarr()
        {
            InitializeComponent();
        }


        private void WarrBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void statser_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void srtPlus_Click(object sender, RoutedEventArgs e)
        {
            warior.lvl += 1;
            lblLevel.Content = warior.lvl;
            lblHealth.Content = warior.lvl;
        }

        private void lblSrt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
