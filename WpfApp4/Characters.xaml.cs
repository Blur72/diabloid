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
    /// Логика взаимодействия для Characters.xaml
    /// </summary>
    public partial class Characters : Page
    {
        public Characters()
        {
            InitializeComponent();
        }

        private void charBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (lstTeam.Items.Count == 0)
            {
                lstTeam.Items.Add("Warrior");
                lstTeam.Items.Add("Rogue");
                lstTeam.Items.Add("Sorcerer");
            }
            else
            {

            }


        }

        private void charOk_Click(object sender, RoutedEventArgs e)
        {
            if (lstTeam.SelectedItem == "Warrior" ) 
            {
                NavigationService.Navigate(new statsWarr());
            }
        }
    }
}
