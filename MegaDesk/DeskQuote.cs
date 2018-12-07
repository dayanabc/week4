using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk
{
    class DeskQuote
    {
        public Desk Desk { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Shipping { get; set; }
        const decimal BASE_PRICE = 200;
        public decimal materialIn;
        const decimal DRAWER_COST = 50.00M;
        
        public DeskQuote(Desk Desk, string Name, decimal shippingNum)
        {
            this.Desk = Desk;
            this.Name = Name;
            this.Date = DateTime.Now;


            decimal drawerPrice = this.Desk.NumberOfDrawers * DRAWER_COST;
            decimal SurfaceArea = Desk.width * Desk.depth;
            this.Shipping = CalcShipment(shippingNum, SurfaceArea);

            decimal materialPrice = GetMaterialPrice(Desk.materialNum);
            this.Price = GetQuote(SurfaceArea, this.Shipping, materialPrice, drawerPrice);

            materialIn = Desk.materialNum;

        }
 
        public decimal CalcShipment(decimal shippingNum, decimal surfaceArea)

        {
            decimal shippingPrice;

            if (shippingNum == 3)
            {
                if (surfaceArea < 1000)

                {
                    shippingPrice = 60;
                }
                else if (surfaceArea < 2001)
                {
                    shippingPrice = 70;
                }
                else
                {
                   shippingPrice  = 80;
                }
            }
            else if (shippingNum == 5)
            {
                if (surfaceArea < 1000)
                {
                    shippingPrice = 40;
                }
                else if (surfaceArea < 2001)               
                {
                    shippingPrice = 45;
                }
                else
                {
                    shippingPrice = 60;
                }
            }
            else
            {
                if (surfaceArea < 1000)
                {
                    shippingPrice = 60;
                }
                else if (surfaceArea < 2001)
                {
                    shippingPrice = 70;
                }
                else
                {
                    shippingPrice = 80;
                }
            }
            return shippingPrice;
        }

        public decimal GetMaterialPrice(decimal materialNumber)

        {
            decimal surfaceMaterialPrice;

            if (materialNumber == 1)
            {
                surfaceMaterialPrice = 200;
            }
            else if (materialNumber == 2)
            {
               surfaceMaterialPrice = 100;
            }
            else if (materialNumber == 3)
            {
                surfaceMaterialPrice = 50;
            }
            else if (materialNumber == 4)
            {
                surfaceMaterialPrice = 300;
            }
            else
            {
                surfaceMaterialPrice = 125;
            }
            return surfaceMaterialPrice;
        }

        public decimal GetQuote(decimal surfaceArea, decimal shipping, decimal materialPrice, decimal drawerPrice)

        {
            decimal price;


            if (surfaceArea < 1000)
            {
                price = BASE_PRICE + shipping + materialPrice + drawerPrice;
            }
            else
            {
                price = BASE_PRICE + surfaceArea + shipping + materialPrice + drawerPrice;
            }

            return price;

        }

    }

}