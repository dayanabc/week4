using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    { 
       public enum DesktopMaterial
    {
        oak,
        roseWood,
        veneer,
        pine,
        laminate

    }

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int DeskId { get; set; }

       public DesktopMaterial Material { get; set; }

    }
}
