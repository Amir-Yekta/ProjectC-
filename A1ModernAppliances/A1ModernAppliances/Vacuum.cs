using ModernAppliances.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances
{
    class Vacuum : Appliance
    {
        public string Grade;
        public short BattreyVoltage;
        public Vacuum (long itemNumber, string brand, int quantity, decimal wattage, string color, decimal price, string grade, short batteryVoltage) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            BattreyVoltage = batteryVoltage;


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
                + "Grade:\t" + Grade + "\n"
                + "Battry Voltage:\t" + BattreyVoltage);
        }
    }
}
