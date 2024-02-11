using ModernAppliances.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances
{
    class Dishwasher: Appliance
    {
        public string Feature;
        public string SoundRating;
        public Dishwasher(long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, string feature, string soundRating) : base(itemNumber, brand, quantity, wattage, color, price)
        {
           Feature = feature;
           SoundRating = soundRating;


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
                + "Features:\t" + Feature + "\n"
                + "Sound Rating:\t" + SoundRating);

        }
    }
}
