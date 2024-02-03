using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class units
    {
        public units(int lvl, int str, int magic, int dex, int intl, int vit, int health, int mana, int physDam, int armor, int magDam, int magDef, int crtChance, int crtDam)
        {
            this.lvl = lvl;
            this.str = str;
            this.intel = magic;
            this.dex = dex;
            this.intl = intl;
            this.vit = vit;
            this.health = health;
            this.mana = mana;
            this.physDam = physDam;
            this.armor = armor;
            this.magDam = magDam;
            this.magDef = magDef;
            this.crtChance = crtChance;
            this.crtDam = crtDam;
        }

        public int lvl { get; set; }
        public int str { get; set; }
        public int intel { get; set; }
        public int dex { get; set; }
        public int intl { get; set; }
        public int vit { get; set; }
        public int health { get; set; }
        public int mana { get; set; }
        public int physDam { get; set;}
        public int armor { get; set; }
        public int magDam { get; set; }
        public int magDef { get; set; }
        public int crtChance { get; set; }
        public int crtDam { get; set;}
    }
}

