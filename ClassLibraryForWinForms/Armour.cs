using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class Armour:Items
    {
        public int DefenseAdded { get; set; }
        public Armour():base() 
        {
            DefenseAdded = 0;
        }
        public Armour(string name, int defenseAdded):base(name)
        {
            DefenseAdded = defenseAdded;
        }
    }
}
