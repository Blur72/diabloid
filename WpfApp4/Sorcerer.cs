using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Sorcerer : units
    {
        public Sorcerer(int lvl, int str, int intel, int dex, int vit, int health, int mana, double physDam, double armor, double magDam, double magDef, double crtChance, double crtDam) : base(lvl, str, intel, dex, intel, vit, health, mana, physDam, armor, magDam, magDef, crtChance, crtDam)
        {
            lvl = 1;
            str = 15;
            intel = 20;
            dex = 35;
            vit = 15;
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