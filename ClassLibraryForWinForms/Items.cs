using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class Items
    {
        public string Name { get; set; }
        public Items() { Name = "none"; }
        public Items(string name) {  Name = name; }
    }
}
