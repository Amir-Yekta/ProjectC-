using ModernAppliances.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances
{
    class Refrigerator : Appliance
    {

        public short Doors;
        public int Width;
        public int Height;
        public Refrigerator(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, short doors, int width, int height) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Doors = doors;
            Width = width;
            Height = height;


        }

        public override string ToString()
        {
            return
                ("Item Number:\t" + ItemNumber + "\n"
                + "Brand:\t" + Brand + "\n"
                + "Quantity:\t" + Quantity + "\n"
                + "Wattage:\t" + Wattage + "\n"
                + "Color:\t" + Color + "\n"
                + "Price:\t" + Price + "\n"
                + "Doors:\t" + Doors + "\n"
                + "Width:\t" + Width + "\n"
                + "Height\t" + Height);

        }
    }
}
