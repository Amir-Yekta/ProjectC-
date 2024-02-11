using ModernAppliances.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances
{
    class Microwave : Appliance
    {
        public float Capacity;

        public char RoomType;

        public Microwave(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, float capacity, char roomType) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Capacity = capacity;
            RoomType = roomType;

           
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
                + "Capacity:\t" + Capacity + "\n"
                + "Room Type\t" + RoomType);    
                 
        }

    }
}
