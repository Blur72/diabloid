using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace WpfApp4
{
    internal class Sword : Istatus_effect, Iunits
    {
       public int physicaldamageN { get; set; }
       public int Lowstrdex { get; set;}
      
       public bool shieldaccess { get; set; } 
        public bool rare { get; set; }
        public bool ench { get; set; }
        public double armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double crtChance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double crtDam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int dex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int intel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int intl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int lvl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double magDam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double magDef { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int mana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double physDam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int str { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int vit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Random rnd = new Random();

        public void effect(bool rare, bool ench)
        {
            if (rare == true) 
            {
                if(rnd .Next(1, 18) == 1)
                {
                    vit += 5;
                }
                else
                if (rnd.Next(1, 18) == 1)
                {
                    str += 5;
                }
            }
        }
    }
}
