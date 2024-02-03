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
        Warior warior = new Warior(1, 30, 10, 15, 25, 0, 0, 0, 0, 0, 0, 0, 0);

        public statsWarr()
        {
            InitializeComponent();
            lblHealth.Content = warior.vit + warior.str;
            lblLevel.Content = warior.lvl;
            lblSrt.Content = warior.str;
            lblVit.Content = warior.vit;
            lblDex.Content = warior.dex;
            lblInt.Content = warior.intel;
            lblMana.Content = warior.intel;
        }


        private void WarrBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void srtPlus_Click(object sender, RoutedEventArgs e)
        {
            warior.str += 1;
            lblSrt.Content = warior.str;
            lblHealth.Content = warior.vit + warior.str;
        }

        private void vitPlus_Click(object sender, RoutedEventArgs e)
        {
            warior.vit += 1;
            lblVit.Content = warior.vit;
            lblHealth.Content = warior.vit + warior.str;
        }

        private void intPlus_Click(object sender, RoutedEventArgs e)
        {
            warior.intel += 1;
            warior.magDam += 0.2;
            warior.magDef += 0.5;
            lblmDam.Content = warior.magDam;
            lblInt.Content = warior.intel;
            lblMana.Content = warior.intel;
            lblmDef.Content = warior.magDef;
            string help = Convert.ToString(warior.magDam);
            if (help.Length > 3)
            {
                warior.magDam = Convert.ToInt32(warior.magDam);
            }
        }

        private void dexPlus_Click(object sender, RoutedEventArgs e)
        {
            warior.dex += 1;
            warior.armor += 1;
            warior.crtChance += 0.2;
            warior.crtDam += 0.1;
            lblDex.Content = warior.dex;
            lblArmor.Content = warior.armor;
            lblcrtCh.Content = warior.crtChance;
            lblcrtDam.Content = warior.crtDam;
        }

        private void srtMinus_Click(object sender, RoutedEventArgs e)
        {
            warior.str -= 1;
            lblSrt.Content = warior.str;
            lblHealth.Content = warior.vit + warior.str;
        }

        private void dexMinus_Click(object sender, RoutedEventArgs e)
        {
            warior.dex -= 1;
            warior.armor -= 1;
            warior.crtChance -= 0.2;
            warior.crtDam -= 0.1;
            lblDex.Content = warior.dex;
            lblArmor.Content = warior.armor;
            lblcrtCh.Content = warior.crtChance;
            lblcrtDam.Content = warior.crtDam;
        }

        private void intMinus_Click(object sender, RoutedEventArgs e)
        {
            warior.intel -= 1;
            warior.magDam -= 0.2;
            warior.magDef -= 0.5;
            lblmDam.Content = warior.magDam;
            lblInt.Content = warior.intel;
            lblMana.Content = warior.intel;
            lblmDef.Content = warior.magDef;
        }

        private void vitMinus_Click(object sender, RoutedEventArgs e)
        {
            warior.vit -= 1;
            lblVit.Content = warior.vit;
            lblHealth.Content = warior.vit + warior.str;
        }

        private void lvlPlus_Click(object sender, RoutedEventArgs e)
        {
            warior.lvl += 1;
            lblLevel.Content = warior.lvl;
            lblPoints.Content = warior.lvl;
        }
    }
}
