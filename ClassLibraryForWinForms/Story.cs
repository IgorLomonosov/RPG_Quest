using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class Story
    {
        private static Story instance;

        public int Location { get; set; }
        public int GameState { get; set; }
        public bool LeatherArmourAquired { get; set; }
        public bool HardenedLeatherArmourAquired { get; set; }
        public bool IronArmourAquired { get; set; }
        public bool PlateArmourAquired { get; set; }
        public bool WoodenSwordAquired { get; set; }
        public bool StoneSwordAquired { get; set; }
        public bool IronSwordAquired { get; set; }
        public bool CurvedDaggerAquired { get; set; }
        public bool PermissionToEnterTown { get; set; }
        public bool KeyFromTowerAquired { get; set; }

        private Story()
        {
            Location = 0;
            GameState = 0;
            LeatherArmourAquired = false;
            HardenedLeatherArmourAquired = false;
            IronArmourAquired = false;
            PlateArmourAquired = false;
            WoodenSwordAquired = false;
            StoneSwordAquired = false;
            IronSwordAquired = false;
            CurvedDaggerAquired = false;
            PermissionToEnterTown = false;
            KeyFromTowerAquired = false;
        }

        public static Story Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Story();
                }
                return instance;
            }
        }
    }

}
