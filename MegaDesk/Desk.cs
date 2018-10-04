using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    { 
       public enum SurfaceMaterial
    {
        Oak,
        RoseWood,
        Veneer,
        Pine,
        Laminate

    }
   
       public int DeskId { get; set; }

       public int DesktopMaterial { get; set; }

       public int Width { get; set; } 


    }
}
