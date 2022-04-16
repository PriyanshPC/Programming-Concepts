using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                //Priyansh Chaudhary & Wisam Mossua
namespace A4ChaudharyPriyanshP1
{
    class Program
    {

            static public String[] arrayIceCreamPails = new string[39] as String[];
            static public String Chosen_Option = "A";
       
            static void Main(string[] args)
            {
            //Initialising Array for IceCreamPails for 40 items - 0 to 39
            //
            for (int i = 0; i < 39; i++)
                {
                    arrayIceCreamPails[i] = "NONE";
                }
                
                while (Chosen_Option != "E")
                {
                    MainMenu();
                }
                Console.WriteLine("Good Bye, Exiting the program now");
                System.Threading.Thread.Sleep(1000);
            }

            private static void Option_A()
            {
                bool validData = false;
                String selected_Brand = "";
                String selected_Flavour;
                selected_Flavour = null;
                string DataEntry = null;

                while (selected_Brand != "DONE")
                {
                    selected_Brand = Select_Brand();
                    if (selected_Brand != "Blue Bell" && selected_Brand != "Private Label" && selected_Brand != "Nestle" && selected_Brand != "Amul" && selected_Brand != "Cream Bell" && selected_Brand != "DONE")
                    {
                        Console.WriteLine("Invalid Input , Try Again");
                        // selected_Brand = Select_Brand();
                    }
                    else if (selected_Brand == "DONE")
                    {
                        break;
                    }
                    else
                    {
                        selected_Flavour = Select_Flavour();
                        int FlavID;
                        int Flav;
                        while (selected_Flavour != "1" && selected_Flavour != "2" && selected_Flavour != "3")
                        {
                            selected_Flavour = Select_Flavour();

                            try
                            {
                                FlavID = Convert.ToInt32(selected_Flavour);
                                switch (FlavID)
                                {
                                    case 1:
                                        Flav = FlavID / 1;
                                        break;
                                    case 2:
                                        Flav = FlavID / 2;
                                        break;
                                    case 3:
                                        Flav = FlavID / 3;
                                        break;
                                    case 0:
                                        FlavID = 1;
                                        Flav = FlavID / 0;
                                        break;
                                    default:
                                        Flav = FlavID / 0;
                                        break;

                                }

                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Invalid Input , Try Again. Please enter either 1, 2 or 3");
                                // selected_Brand = Select_Brand();
                                selected_Flavour = "";
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Input , Try Again. Please enter either 1, 2 or 3");
                            }
                        }

                        DataEntry = selected_Brand + "-" + selected_Flavour;
                        Console.WriteLine("Selected Data is " + DataEntry);
                        validData = true;
                    }

                    while (validData)
                    {
                        (Boolean Duplicates, int index) = Check_Duplicates(DataEntry);
                        if (Duplicates)
                        {
                            Console.WriteLine("Error Ice-cream record already exists");
                            validData = false;
                        }
                        else
                        {
                            arrayIceCreamPails[index] = DataEntry;
                            Console.WriteLine("Data entered successfully at arrayIceCreamPails" + index + " = " + DataEntry);
                            validData = false;
                        }
                    }

                }
                Console.WriteLine("Exiting....");
                selected_Brand = "";

            }

            private static void Option_B()
            {
                Console.WriteLine("Enter the entry to be edited in format eg. Nestle-3");
                string EditEntry = Console.ReadLine();
                int EditIndex = 100;
                bool validData = false;
                String selected_Brand = "";
                String selected_Flavour;
                selected_Flavour = null;
                string DataEntry = null;
                bool DataEdited = false;
                for (int i = 0; i < 30;)
                {

                    if (arrayIceCreamPails[i] == EditEntry)
                    {
                        Console.WriteLine("Brand Information Found");
                        EditIndex = i;
                        break;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (EditIndex == 100)
                {
                    Console.WriteLine("Brand record not found for that entry");
                }
                else
                {
                    Console.WriteLine("please enter updated information");
                    while (true)
                    {
                        selected_Brand = Select_Brand();
                        if (selected_Brand != "Blue Bell" && selected_Brand != "Private Label" && selected_Brand != "Nestle" && selected_Brand != "Amul" && selected_Brand != "Cream Bell")
                        {
                            Console.WriteLine("Invalid Input , Try Again");
                            // selected_Brand = Select_Brand();
                        }

                        else
                        {
                            selected_Flavour = Select_Flavour();
                            int FlavID;
                            int Flav;
                            while (selected_Flavour != "1" && selected_Flavour != "2" && selected_Flavour != "3")
                            {
                                selected_Flavour = Select_Flavour();

                                try
                                {
                                    FlavID = Convert.ToInt32(selected_Flavour);
                                    switch (FlavID)
                                    {
                                        case 1:
                                            Flav = FlavID / 1;
                                            break;
                                        case 2:
                                            Flav = FlavID / 2;
                                            break;
                                        case 3:
                                            Flav = FlavID / 3;
                                            break;
                                        case 0:
                                            FlavID = 1;
                                            Flav = FlavID / 0;
                                            break;
                                        default:
                                            Flav = FlavID / 0;
                                            break;

                                    }

                                }
                                catch (DivideByZeroException )
                                {
                                    Console.WriteLine("Invalid Input , Try Again. Please enter either 1, 2 or 3");
                                    // selected_Brand = Select_Brand();
                                    selected_Flavour = "";
                                }
                                catch (FormatException )
                                {
                                    Console.WriteLine("Invalid Input , Try Again. Please enter either 1, 2 or 3");
                                }
                            }

                            DataEntry = selected_Brand + "-" + selected_Flavour;
                            Console.WriteLine("Selected Data is " + DataEntry);
                            validData = true;
                        }

                        while (validData)
                        {
                            (Boolean Duplicates, int index) = Check_Duplicates(DataEntry);
                            if (Duplicates)
                            {
                                Console.WriteLine("Error Ice-cream record already exists");
                                validData = false;
                            }
                            else
                            {
                                Console.WriteLine("Data updated successfully at arrayIceCreamPails [" + index + "] = " + DataEntry);
                                arrayIceCreamPails[EditIndex] = DataEntry;
                                validData = false;
                                DataEdited = true;


                            }
                        }
                        if (DataEdited)
                        {
                            break;
                        }


                    }
                }
            }

            private static void Option_C()
            {
                for (int i = 0; i < 39; i++)
                {
                    if (arrayIceCreamPails[i] != "NONE")
                    {
                        Console.WriteLine(arrayIceCreamPails[i]);
                    }
                    else
                    {
                        Console.ReadLine();
                        break;
                    }
                }
            }

            private static void Option_D()
            {
                Console.WriteLine("Enter the entry to be edited in format eg. Nestle-3");
                string EditEntry = Console.ReadLine();
                int EditIndex = 100;

                for (int i = 0; i < 30;)
                {

                    if (arrayIceCreamPails[i] == EditEntry)
                    {
                        Console.WriteLine("Brand Information Found");
                        EditIndex = i;
                        break;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (EditIndex == 100)
                {
                    Console.WriteLine("Brand record not found for that entry");
                }
                else
                {
                    String Decision = null;
                    while (Decision != "N")
                        Console.WriteLine("brand information found are you sure you want to delete Y/N");
                    Decision = Console.ReadLine();
                    {
                        if (Decision == "Y")
                        {
                            arrayIceCreamPails[EditIndex] = "NONE";
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                    }
                }


            }

            private static Tuple<bool, int> Check_Duplicates(String DataEntry)
            {
                bool result = false;
                int index = 0;
                //Check for duplicates
                for (int i = 0; i < 30;)
                {

                    if (arrayIceCreamPails[i] == DataEntry)
                    {
                        DataEntry = "";
                        result = true;
                        break;
                        i++;
                        Console.WriteLine("Dup");
                    }
                    else if (arrayIceCreamPails[i] == "NONE")
                    {
                        //arrayIceCreamPails[i] = DataEntry;

                        Console.WriteLine("Entry");
                        index = i;
                        result = false;
                        break;
                        // i++;
                    }
                    else
                    {
                        i++;
                        result = false;

                    }
                }
                return Tuple.Create(result, index);
            }
            static string? Select_Brand()
            {
                Console.WriteLine("Select the IceCream Brand or Enter \"Done\" to Exit to Main Menu ");
                Console.WriteLine("1. Blue Bell");
                Console.WriteLine("2. Private Label");
                Console.WriteLine("3. Nestle");
                Console.WriteLine("4. Amul");
                Console.WriteLine("5. Cream Bell");
                string selected_Brand = Console.ReadLine();
                return selected_Brand;
            }
            static string? Select_Flavour()
            {
                Console.WriteLine("Select the Flavour - (Enter number 1 to 3");
                Console.WriteLine("1. Vanilla");
                Console.WriteLine("2. Chocolate");
                Console.WriteLine("3. Strawberry");
                string selected_Flavour_ID = (Console.ReadLine());
                return selected_Flavour_ID;
            }
            private static void MainMenu()
            {
                Console.WriteLine("Hey yaa Welcome");
                Console.WriteLine("Choose one from following");
                Console.WriteLine("A.Add new ice- cream pail detail - Brand Name & flavour(for example Cadbury-2)");
                Console.WriteLine("B.Edit existing ice - cream pail details(Brand Name & flavour) ");
                Console.WriteLine("C.Display all ice - cream pails in store(display the Brand Name & flavour)");
                Console.WriteLine("D.Delete ice-cream pail Information");
                Console.WriteLine("E.Exit the program (Please use CAPS E)");
                Chosen_Option = Console.ReadLine();
                switch (Chosen_Option)
                {
                    case "A":
                    case "a":
                        Option_A();
                        break;
                    case "B":
                    case "b":
                    Option_B();
                        break;
                    case "C":
                    case "c":
                    Option_C();
                        break;
                    case "D":
                    case "d":
                    Option_D();
                        break;
                    default:
                        break;
                }
            }
        }
    }