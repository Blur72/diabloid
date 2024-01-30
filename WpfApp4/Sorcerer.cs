using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Sorcerer : units
    {
        public Sorcerer(int lvl, int str, int intel, int dex, int intl, int vit, int health, int mana, int physDam, int armor, int magDam, int magDef, int crtChance, int crtDam) : base(lvl, str, intel, dex, intl, vit , health,  mana,  physDam, armor,  magDam,  magDef,  crtChance,  crtDam)
        {
            lvl = 1;
            str = 15;
            dex = 20;
            intel = 35;
            vit = 15;
        }
    }
}