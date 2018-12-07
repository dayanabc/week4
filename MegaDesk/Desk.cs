using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    };
       
        public decimal widthNum;
        public decimal materialNum;
        public decimal  depthNum;
        private decimal drawerNum;

        public Desk(decimal widthNum, decimal depthNum, decimal drawerNum, decimal materialNum)
        {
            this.widthNum = widthNum;
            this.depthNum = depthNum;
            this.drawerNum = drawerNum;
            this.materialNum = materialNum;
        }

        public decimal width { get; set; }

        public decimal depth { get; set; }

        public int deskId { get; set; }
        
       public DesktopMaterial Material { get; set; }
        public decimal NumberOfDrawers { get; set; }
    }
}
