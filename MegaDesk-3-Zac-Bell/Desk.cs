using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Zac_Bell
{
    class Desk
    {
        public int Width {get; set;}
        public int Depth { get; set; }
        public int NumOfDrawers { get; set; }
        enum SurfaceMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
    }
}
