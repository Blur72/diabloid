using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Warior : units
    { 
        
        public Warior(int lvl, int str, int intel, int dex, int vit, int health, int mana, int physDam, int armor, int magDam, int magDef, int crtChance, int crtDam) : base(lvl, str, intel, dex, intel, vit, health, mana, physDam, armor, magDam, magDef, crtChance, crtDam)
        {
            lvl = 1;
            str = 30;
            intel = 10;
            dex = 15;
            vit = 25;
        }
    }
}
