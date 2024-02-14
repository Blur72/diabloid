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
        Rogue rogue = new Rogue(1, 20, 15, 30, 20, 0, 0, 0, 0, 0, 0, 0, 0);
        Sorcerer sorcerer = new Sorcerer(1, 15, 35, 20, 15, 0, 0, 0, 0, 0, 0, 0, 0);
        
        
        int points;
        public statsWarr()
        {
            InitializeComponent();
        }


        private void WarrBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void nextCreator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Creator(warior.physDam));
        }

        private void srtPlus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        warior.str += 1;
                        lblSrt.Content = warior.str + "/250";
                        lblHealth.Content = warior.vit + warior.str;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        warior.lvl += 1;
                        lblLevel.Content = warior.lvl;
                        lblpDam.Content = warior.str;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        rogue.str += 1;
                        lblSrt.Content = rogue.str + "/250";
                        lblHealth.Content = rogue.vit + rogue.str;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        rogue.lvl += 1;
                        lblLevel.Content = rogue.lvl;
                        lblLevel.Content = rogue.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        sorcerer.str += 1;
                        lblSrt.Content = sorcerer.str + "/250";
                        lblHealth.Content = sorcerer.vit + sorcerer.str;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        sorcerer.lvl += 1;
                        lblLevel.Content = sorcerer.lvl;
                        lblLevel.Content = sorcerer.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
        }

        private void vitPlus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        warior.vit += 1;
                        lblVit.Content = warior.vit + "/100";
                        lblHealth.Content = warior.vit + warior.str;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        warior.lvl += 1;
                        lblLevel.Content = warior.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        rogue.vit += 1;
                        lblVit.Content = rogue.vit + "/100";
                        lblHealth.Content = rogue.vit + rogue.str;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        rogue.lvl += 1;
                        lblLevel.Content = rogue.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        sorcerer.vit += 1;
                        lblVit.Content = sorcerer.vit + "/100";
                        lblHealth.Content = sorcerer.vit + sorcerer.str;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        sorcerer.lvl += 1;
                        lblLevel.Content = sorcerer.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
        }

        private void intPlus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        warior.intel += 1;
                        warior.magDam += 0.2;
                        warior.magDef += 0.5;
                        lblmDam.Content = Math.Round(Convert.ToDecimal(warior.magDam), 1);
                        lblInt.Content = warior.intel + "/50";
                        lblMana.Content = warior.intel;
                        lblmDef.Content = warior.magDef;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        sorcerer.lvl += 1;
                        lblLevel.Content = sorcerer.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        rogue.intel += 1;
                        rogue.magDam += 0.2;
                        rogue.magDef += 0.5;
                        lblmDam.Content = Math.Round(Convert.ToDecimal(rogue.magDam), 1);
                        lblInt.Content = rogue.intel + "/50";
                        lblMana.Content = rogue.intel;
                        lblmDef.Content = rogue.magDef;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        sorcerer.lvl += 1;
                        lblLevel.Content = sorcerer.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        sorcerer.intel += 1;
                        sorcerer.magDam += 1;
                        sorcerer.magDef += 1;
                        lblmDam.Content = Math.Round(Convert.ToDecimal(sorcerer.magDam), 1);
                        lblInt.Content = sorcerer.intel + "/50";
                        lblMana.Content = sorcerer.intel;
                        lblmDef.Content = sorcerer.magDef;
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        sorcerer.lvl += 1;
                        lblLevel.Content = sorcerer.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }   
        }

        private void dexPlus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        warior.dex += 1;
                        warior.armor += 1;
                        warior.crtChance += 0.2;
                        warior.crtDam += 0.1;
                        lblDex.Content = warior.dex + "/80";
                        lblArmor.Content = Math.Round(Convert.ToDecimal(warior.armor), 1);
                        lblcrtCh.Content = Math.Round(Convert.ToDecimal(warior.crtChance), 1);
                        lblcrtDam.Content = Math.Round(Convert.ToDecimal(warior.crtDam), 1);
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        warior.lvl += 1;
                        lblLevel.Content = warior.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                    {
                        rogue.dex += 1;
                        rogue.armor += 1.5;
                        rogue.crtChance += 0.2;
                        rogue.crtDam += 0.1;
                        lblDex.Content = rogue.dex + "/80";
                        lblArmor.Content = Math.Round(Convert.ToDecimal(rogue.armor), 1);
                        lblcrtCh.Content = Math.Round(Convert.ToDecimal(rogue.crtChance), 1);
                        lblcrtDam.Content = Math.Round(Convert.ToDecimal(rogue.crtDam), 1);
                        int points = Convert.ToInt32(lblPoints.Text);
                        points--;
                        lblPoints.Text = Convert.ToString(points);
                        warior.lvl += 1;
                        lblLevel.Content = warior.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (string.IsNullOrWhiteSpace(lblPoints.Text))
                {
                    MessageBox.Show("Количетсов очков не заполнено!");
                    return;
                }
                else
                {
                    if (lblPoints.Text != "0")
                {
                    sorcerer.dex += 1;
                    sorcerer.armor += 1;
                    sorcerer.crtChance += 0.2;
                    sorcerer.crtDam += 0.1;
                    lblDex.Content = sorcerer.dex + "/80";
                    lblArmor.Content = Math.Round(Convert.ToDecimal(sorcerer.armor), 1);
                    lblcrtCh.Content = Math.Round(Convert.ToDecimal(sorcerer.crtChance), 1);
                    lblcrtDam.Content = Math.Round(Convert.ToDecimal(sorcerer.crtDam), 1);
                    int points = Convert.ToInt32(lblPoints.Text);
                    points--;
                    lblPoints.Text = Convert.ToString(points);
                    sorcerer.lvl += 1;
                    lblLevel.Content = sorcerer.lvl;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно очков!");
                    }
                }
            }
        }

        private void srtMinus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (lblPoints.Text != "0")
                {
                    warior.str -= 1;
                    lblSrt.Content = warior.str;
                    lblHealth.Content = warior.vit + warior.str;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                    lblpDam.Content = warior.str;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (lblPoints.Text != "0")
                {
                    rogue.str -= 1;
                    lblSrt.Content = rogue.str;
                    lblHealth.Content = rogue.vit + rogue.str;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                    lblpDam.Content = rogue.str;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (lblPoints.Text != "0")
                {
                    sorcerer.str -= 1;
                    lblSrt.Content = sorcerer.str;
                    lblHealth.Content = sorcerer.vit + sorcerer.str;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                    lblpDam.Content = sorcerer.str;
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
        }

        private void dexMinus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (lblPoints.Text != "0")
                {
                    warior.dex -= 1;
                    warior.armor -= 1;
                    warior.crtChance -= 0.2;
                    warior.crtDam -= 0.1;
                    lblDex.Content = warior.dex;
                    lblArmor.Content = Math.Round(Convert.ToDecimal(warior.armor), 1);
                    lblcrtCh.Content = Math.Round(Convert.ToDecimal(warior.crtChance), 1);
                    lblcrtDam.Content = Math.Round(Convert.ToDecimal(warior.crtDam), 1);
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (lblPoints.Text != "0")
                {
                    rogue.dex -= 1;
                    rogue.armor -= 1.5;
                    rogue.crtChance -= 0.2;
                    rogue.crtDam -= 0.1;
                    lblDex.Content = rogue.dex;
                    lblArmor.Content = Math.Round(Convert.ToDecimal(rogue.armor), 1);
                    lblcrtCh.Content = Math.Round(Convert.ToDecimal(rogue.crtChance), 1);
                    lblcrtDam.Content = Math.Round(Convert.ToDecimal(rogue.crtDam), 1);
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (lblPoints.Text != "0")
                {
                    sorcerer.dex -= 1;
                    sorcerer.armor -= 1;
                    sorcerer.crtChance -= 0.2;
                    sorcerer.crtDam -= 0.1;
                    lblDex.Content = sorcerer.dex;
                    lblArmor.Content = Math.Round(Convert.ToDecimal(sorcerer.armor), 1);
                    lblcrtCh.Content = Math.Round(Convert.ToDecimal(sorcerer.crtChance), 1);
                    lblcrtDam.Content = Math.Round(Convert.ToDecimal(sorcerer.crtDam), 1);
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
        }

        private void intMinus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (lblPoints.Text != "0")
                {
                    warior.intel -= 1;
                    warior.magDam -= 0.2;
                    warior.magDef -= 0.5;
                    lblmDam.Content = Math.Round(Convert.ToDecimal(warior.magDam), 1);
                    lblInt.Content = warior.intel;
                    lblMana.Content = warior.intel;
                    lblmDef.Content = warior.magDef;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (lblPoints.Text != "0")
                {
                    rogue.intel -= 1;
                    rogue.magDam -= 0.2;
                    rogue.magDef -= 0.5;
                    lblmDam.Content = Math.Round(Convert.ToDecimal(rogue.magDam), 1);
                    lblInt.Content = rogue.intel;
                    lblMana.Content = rogue.intel;
                    lblmDef.Content = rogue.magDef;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (lblPoints.Text != "0")
                {
                    sorcerer.intel -= 1;
                    sorcerer.magDam -= 1;
                    sorcerer.magDef -= 1;
                    lblmDam.Content = Math.Round(Convert.ToDecimal(sorcerer.magDam), 1);
                    lblInt.Content = sorcerer.intel;
                    lblMana.Content = sorcerer.intel;
                    lblmDef.Content = sorcerer.magDef;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
        }

        private void vitMinus_Click(object sender, RoutedEventArgs e)
        {
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                if (lblPoints.Text != "0")
                {
                    warior.vit -= 1;
                    lblVit.Content = warior.vit;
                    lblHealth.Content = warior.vit + warior.str;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                if (lblPoints.Text != "0")
                {
                    rogue.vit -= 1;
                    lblVit.Content = rogue.vit;
                    lblHealth.Content = rogue.vit + rogue.str;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                if (lblPoints.Text != "0")
                {
                    sorcerer.vit -= 1;
                    lblVit.Content = sorcerer.vit;
                    lblHealth.Content = sorcerer.vit + sorcerer.str;
                    int points = Convert.ToInt32(lblPoints.Text);
                    points++;
                    lblPoints.Text = Convert.ToString(points);
                }
                else
                {
                    MessageBox.Show("Недостаточно очков!");
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lblClass.Text = (string)App.Current.Resources["Almazniy"];
            if ((string)App.Current.Resources["Almazniy"] == "Rogue")
            {
                lblHealth.Content = rogue.vit + rogue.str;
                lblLevel.Content = rogue.lvl;
                lblSrt.Content = rogue.str + "/65";
                lblDex.Content = rogue.dex + "/250";
                lblInt.Content = rogue.intel + "/70";
                lblVit.Content = rogue.vit + "/80";
                lblMana.Content = rogue.intel;
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Warrior")
            {
                lblHealth.Content = warior.vit + warior.str;
                lblLevel.Content = warior.lvl;
                lblSrt.Content = warior.str + "/250";
                lblDex.Content = warior.dex + "/80";
                lblInt.Content = warior.intel + "/50";
                lblVit.Content = warior.vit + "/100";
                lblMana.Content = warior.intel;
            }
            else
            if ((string)App.Current.Resources["Almazniy"] == "Sorcerer")
            {
                lblHealth.Content = sorcerer.vit + sorcerer.str;
                lblLevel.Content = sorcerer.lvl;
                lblSrt.Content = sorcerer.str + "/45";
                lblDex.Content = sorcerer.dex + "/80";
                lblInt.Content = sorcerer.intel + "/250";
                lblVit.Content = sorcerer.vit + "/70";
                lblMana.Content = sorcerer.intel;
            }
        }

        private void slotWeapon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = new Image();
            img.Source = new BitmapImage(new Uri("/iamge/image (4).png", UriKind.Relative));
            slot4.Child = img;
            slotWeapon.Child = null;
            WeaponStats.Content = null;
        }

        private void slot4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Image img = new Image();
            img.Source = new BitmapImage(new Uri("/iamge/image (4).png", UriKind.Relative));
            slotWeapon.Child = img;
            slot4.Child = null;
            WeaponStats.Content = warior.str;
        }
    }
}

