using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    internal class Warior : units
    {


        public Warior(int lvl, int str, int intel, int dex, int vit, int health, int mana, double physDam, double armor, double magDam, double magDef, double crtChance, double crtDam) : base(lvl, str, intel, dex, intel, vit, health, mana, physDam, armor, magDam, magDef, crtChance, crtDam)
        {
            lvl = 1;
            str = 30;
            intel = 10;
            dex = 15;
            vit = 25;
            health = vit + str;
            mana = 0;
            physDam = 0;
            armor = 0;
            magDam = 0;
            magDef = 0;
            crtChance = 0;
            crtDam = 0;
        }
        
        
                
                
  

    }
}
