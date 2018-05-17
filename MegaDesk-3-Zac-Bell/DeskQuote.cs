using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Zac_Bell
{
    class DeskQuote
    {
        //Desk: Desk { get; set; }
        public int RushDays { get; set; }
        public string CustName { get; set; }
        public date QuoteDate { get; set; }
        public decimal BasePrice { get; set; }
        public int SurfaceSize { get; set; }

        public CalcSurfacePrice(int Width, int Depth)
        {
             //-> take in width, depth & calc surface price
            Width = Desk.Width;
            Depth = Desk.Depth;
            decimal test = 12.34;
            return test;
        }

        public CalcLineItemCost(int Width, int Depth, int NumOfDrawers, enum Surface)
        {
            //-> take in width, depth, etc & calc item cost
            decimal test = 12.34;
            return test;
        }

        public CalcRushCost(int RushDays, int SurfaceSize)
        {
             //-> take in rush days and surface size to calc shipping
            decimal test = 12.34;
            return test;
        }

        public CalcTotalQuoteCost(decimal BasePrice, decimal LineItemCost, int RushDays)
        {
            surfPrice = CalcSurfacePrice();
            lineCost = CalcLineItemCost();
            rushCost = CalcRushCost();
            totalCost = BasePrice + surfPrice + lineCost + RushCost;
            return totalCost;
            return decimal;
        }
    }
}
