using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class units : Iunits
    {
        public units(int lvl, int str, int magic, int dex, int intl, int vit, int health, int mana, double physDam, double armor, double magDam, double magDef, double crtChance, double crtDam)
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
        public double physDam { get; set; }
        public double armor { get; set; }
        public double magDam { get; set; }
        public double magDef { get; set; }
        public double crtChance { get; set; }
        public double crtDam { get; set; }
    }
}

