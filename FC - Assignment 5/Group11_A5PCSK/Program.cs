using System;

class Info
{
    public static void Main()
    {
        Console.WriteLine("----Record-----");

        DateTime this_day = DateTime.Today;

        Console.WriteLine(this_day);

        //Information from user to create new record
        Console.WriteLine("Enter Name: ");
        String name = Console.ReadLine();
        Console.WriteLine("Enter Address: ");
        String add = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt16(Console.ReadLine());
        Student obj1 = new Student(name, age, add);

        //function call for other options (menu)
        menu(obj1);
    }

    //method to show menu
    public static void menu(Student obj1)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("----------MENU---------");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Add Record");
        Console.WriteLine("2. Edit Student Record");
        Console.WriteLine("3. Display student record");
        Console.WriteLine("4. Quit");

        //asking user to enter their choice
        Console.WriteLine("------>Enter the number of your choice: ");
        int choice = Convert.ToInt16(Console.ReadLine());

        //if/else condition based on user's choice
        if (choice == 1)
        {
            Main();              //calling main method
        }
        else if (choice == 2)
        {
            edit(obj1);      //calling edit method to edit record
        }
        else if (choice == 3)
        {
            display(obj1);      //calling display method to display student information
        }
        else
        {                   //close the program
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("-------Thanks for your time. Have a great day.--------");
            Console.ResetColor();
            Console.WriteLine();
        }
    }

    //method to Edit student record
    public static void edit(Student obj1)
    {
        String name = obj1.name;
        String add = obj1.address;
        int age = obj1.age;
        Console.WriteLine("Student Information---->");
        Console.WriteLine("1. " + name);
        Console.WriteLine("2. " + add);
        Console.WriteLine("3. " + age);
        Console.WriteLine("-----------------");
        Console.WriteLine("1. Name");
        Console.WriteLine("2. Address");
        Console.WriteLine("3. Age");
        Console.WriteLine("Choose the number you want to edit: ");
        int n = Convert.ToInt16(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("Enter new Name: ");
            String new_name = Console.ReadLine();
            obj1.name = new_name;

        }
        else if (n == 2)
        {
            Console.WriteLine("Enter new address: ");
            String new_add = Console.ReadLine();
            obj1.address = new_add;
        }
        else
        {
            Console.WriteLine("Enter new age: ");
            int new_age = Convert.ToInt16(Console.ReadLine());
            obj1.age = new_age;
        }
        menu(obj1);
    }

    //method to display student record
    public static void display(Student obj1)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("------Student Record-------");
        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("Student Name: " + obj1.name);
        Console.WriteLine("Address: " + obj1.address);
        Console.WriteLine("Age: " + obj1.age);
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
        menu(obj1);
    }

}