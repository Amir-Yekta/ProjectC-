﻿using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance");
            // Create long variable to hold item number
            long itemNum;
            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            itemNum = Convert.ToInt64(userInput);
            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance foundAppliance;
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            foundAppliance = null;
            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            for (int i = 0; i < Appliances.Count; i++)
            {
                if (Appliances[i].ItemNumber == itemNum)
                {
                    foundAppliance = Appliances[i];
                    break;
                }
            }
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            else
            {
                if (foundAppliance.Quantity < 1)
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
                else
                {
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance {foundAppliance.ItemNumber} has been checked out.");
                }
            }
            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."

        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");
            string userBrand = Console.ReadLine();
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            // Create list to hold found Appliance objects
            List<Appliance> brandList = new List<Appliance>();
            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            for (int i = 0; i < Appliances.Count; i++)
            {
                if (Appliances[i].Brand == userBrand)
                {
                    brandList.Add(Appliances[i]);
                }
            }
            DisplayAppliancesFromList(brandList, 0);

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }






        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors");
            // Create variable to hold entered number of doors

            // Get user input as string and assign to variable
            short doorNumber = Convert.ToInt16(Console.ReadLine());
            // Convert user input from string to int and store as number of doors variable.
            Convert.ToInt32(doorNumber);

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate/loop through Appliances
            for (int i = 0; i < Appliances.Count; i++)
            {
                string ItemNumber = Appliances[i].ItemNumber.ToString();


                if (ItemNumber[0] == '1')
                {
                    Refrigerator refrigerator = (Refrigerator)Appliances[i];
                    if (refrigerator.Doors == doorNumber || doorNumber == 0)
                    {
                        foundAppliances.Add(refrigerator);
                    }
                }
            }
            DisplayAppliancesFromList(foundAppliances, 0);
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);

        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"

            // Get user input as string and assign to variable


            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;
            string grade = null;
            while (grade == null)
            {
                Console.WriteLine("Possible options");
                Console.WriteLine("0 - Any");
                Console.WriteLine("1 - Residential");
                Console.WriteLine("2 - Commercial");
                Console.WriteLine("Enter Grade");
                string userGrade = Console.ReadLine();

                switch (userGrade)
                {
                    case "0":
                        grade = "Any";
                        break;
                    case "1":
                        grade = "Residential";
                        break;
                    case "2":
                        grade = "Commercial";
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            // Write "Enter voltage:"
            // Get user input as string
            // Create variable to hold voltage
            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            int voltage = 3;
            while (voltage == 3)
            {
                Console.WriteLine("Possible Options");

                Console.WriteLine("0 - Any");
                Console.WriteLine("2 - 24 Volt");
                Console.WriteLine("1 - 18 Volt");

                Console.WriteLine("Enter voltage");

                string userVoltage = Console.ReadLine();

                switch (userVoltage)
                {
                    case "0":
                        voltage = 0;
                        break;
                    case "1":
                        voltage = 18;
                        break;
                    case "2":
                        voltage = 24;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }


            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            for (int i = 0; i < Appliances.Count; i++)
            {

                string ItemNumber = Appliances[i].ItemNumber.ToString();
                if (ItemNumber[0] == '2')
                {
                    Vacuum vacuum = (Vacuum)Appliances[i];
                    if ((grade == "Any" || grade == vacuum.Grade) && (voltage == 0 || voltage == vacuum.BattreyVoltage))
                    {
                        found.Add(vacuum);
                    }
                }
            }

            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            char room = 'B';
            while (room == 'B')
            {


                // Write "Possible options:"
                Console.WriteLine("Possible options");
                Console.WriteLine("0 - Any");
                Console.WriteLine("1 - Kitchen");
                Console.WriteLine("2 - Worksite");
                Console.WriteLine("Enter roon type:");
                string userInput = Console.ReadLine();
                // Write "0 - Any"
                // Write "1 - Kitchen"
                // Write "2 - Work site"

                // Write "Enter room type:"

                // Get user input as string and assign to variable

                // Create character variable that holds room type


                switch (userInput)
                {
                    case "0":
                        room = 'A';
                        break;
                    case "1":
                        room = 'K';
                        break;
                    case "2":
                        room = 'W';
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;



                }
                // Test input is "0"
                // Assign 'A' to room type variable
                // Test input is "1"
                // Assign 'K' to room type variable
                // Test input is "2"
                // Assign 'W' to room type variable
                // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();
            for (int i = 0; i < Appliances.Count; i++)
            {
                string ItemNumber = Appliances[i].ItemNumber.ToString();


                if (ItemNumber[0] == '3')
                {
                    Microwave microwave = (Microwave)Appliances[i];
                    if (microwave.RoomType == room || room == 'A')
                    {
                        found.Add(microwave);
                    }
                }
            }
            DisplayAppliancesFromList(found, 0);
            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");
            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating");
            // Get user input as string and assign to variable
            string soundRating = null;
            while (soundRating == null)
            {
                string userInput = Console.ReadLine();

                // Create variable that holds sound rating
                switch (userInput)
                {
                    case "0":
                        soundRating = "Any";
                        break;
                    case "1":
                        soundRating = "Qt";
                        break;
                    case "2":
                        soundRating = "Qr";
                        break;
                    case "3":
                        soundRating = "Qu";
                        break;
                    case "4":
                        soundRating = "M";
                        break;
                    default:
                        Console.WriteLine("Invaild option");
                        break;

                }
            }
            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();
            for (int i = 0; i < Appliances.Count; i++)
            {
                string ItemNumber = Appliances[i].ItemNumber.ToString();


                if (ItemNumber[0] == '4' || ItemNumber[0] == '5')
                {
                    Dishwasher dishWasher = (Dishwasher)Appliances[i];
                    if (dishWasher.SoundRating == soundRating || soundRating == "Any")
                    {
                        found.Add(dishWasher);
                    }
                }
            }
            DisplayAppliancesFromList(found, 0);
            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Refrigerators");
            Console.WriteLine("2 - Vacuums");
            Console.WriteLine("3 - Microwaves");
            Console.WriteLine("4 - Dishwashers");
            Console.WriteLine("Enter type of appliance");
            string applianceType = Console.ReadLine();
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances");
            string numAppliences = Console.ReadLine();
            int num = Convert.ToInt32(numAppliences);
            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();
            for (int i = 0; i < Appliances.Count; i++)
            {
                string ItemNumber = Appliances[i].ItemNumber.ToString();
                switch (applianceType)
                {
                    case "0":
                        found.Add(Appliances[i]);
                        break;
                    case "1":
                        if (ItemNumber[0] == '1')
                        {
                            found.Add(Appliances[i]);
                        }
                        break;
                    case "2":
                        if (ItemNumber[0] == '2')
                        {
                            found.Add(Appliances[i]);
                        }
                        break;
                    case "3":
                        if (ItemNumber[0] == '3')
                        {
                            found.Add(Appliances[i]);
                        }
                        break;
                    case "4":
                        if (ItemNumber[0] == '4')
                        {
                            found.Add(Appliances[i]);
                        }
                        break;

                }
            }


            found.Sort(new RandomComparer());
            DisplayAppliancesFromList(found, num);

            // Loop through appliance
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
