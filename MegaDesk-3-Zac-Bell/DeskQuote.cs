using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_Zac_Bell
{
    class DeskQuote: Desk
    {   
        public string CustName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal BasePrice { get; set; }
        public int SurfaceCost { get; set; }
        public enum RushDays
        {
            ThreeDays,
            FiveDays,
            SevenDays,
            Standard
        }

        public double CalcTotalCost(int Width, int Depth, int NumOfDrawers, string RushDays, string Surface)
        {
            //Calc Surface Price
            double basePrice = 200.00;
            int size = Width * Depth;
            double potentialLargeSurfaceCost = 0.00;
            if (size > 1000)
            {
                potentialLargeSurfaceCost = (size - 1000.00);
            }
            double surfacePrice = basePrice + potentialLargeSurfaceCost;

            // Calc Line Cost
            double materialCost = 0.00;
            switch (Surface)
            {
                case "Oak":
                    materialCost = 200.00;
                    break;
                case "Laminate":
                    materialCost = 100.00;
                    break;
                case "Pine":
                    materialCost = 50.00;
                    break;
                case "Rosewood":
                    materialCost = 300.00;
                    break;
                case "Veneer":
                    materialCost = 125.00;
                    break;
            }
            double drawerCost = NumOfDrawers * 50.00;
            double lineCost = drawerCost + materialCost;

            //Calc Rush Cost
            double rushCost = 0.00;
            switch (RushDays)
            {
                case "ThreeDays":
                    if (size < 1000)
                    {
                        rushCost = 60.00;
                    }
                    if (size < 2000)
                    {
                        rushCost = 70.00;
                    }
                    else
                    {
                        rushCost = 80.00;
                    }
                    break;
                case "FiveDays":
                    if (size < 1000)
                    {
                        rushCost = 40.00;
                    }
                    if (size < 2000)
                    {
                        rushCost = 50.00;
                    }
                    else
                    {
                        rushCost = 60.00;
                    }
                    break;
                case "SevenDays":
                    if (size < 1000)
                    {
                        rushCost = 30.00;
                    }
                    if (size < 2000)
                    {
                        rushCost = 35.00;
                    }
                    else
                    {
                        rushCost = 40.00;
                    }
                    break;
                case "Standard":
                    rushCost = 0.00;
                    break;
            }
            
            //Add it all up together
            double totalCost = surfacePrice + lineCost + rushCost;
            return totalCost;
        }
    }
}
