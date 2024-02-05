using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Rogue : units
    {
        public Rogue(int lvl, int str, int intel, int dex, int vit, int health, int mana, double physDam, double armor, double magDam, double magDef, double crtChance, double crtDam) : base(lvl, str, intel, dex, intel, vit, health, mana, physDam, armor, magDam, magDef, crtChance, crtDam)
        {
            lvl = 1;
            str = 20;
            intel = 15;
            dex = 30;
            vit = 20;
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
