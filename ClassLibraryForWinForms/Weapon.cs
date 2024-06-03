using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class Weapon : Items
    {
        public int DamageAdded { get; set; }
        public Weapon():base() { DamageAdded = 0; }
        public Weapon(string name, int damage) : base(name)
        {
            DamageAdded = damage;
        }

    }
}
